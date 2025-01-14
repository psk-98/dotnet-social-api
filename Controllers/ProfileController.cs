using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Dto.Profile;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace dotnet_social_api.Controllers;

[Route("api/profile")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly UserManager<UserProfile> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<UserProfile> _signInManager;
    private readonly ApplicationDBContext _context;
    private readonly IImageService _imageService;

    public ProfileController(UserManager<UserProfile> userManager, ITokenService tokenService, SignInManager<UserProfile> signInManager,
    ApplicationDBContext context, IImageService imageService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
        _context = context;
        _imageService = imageService;

    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userProfile = new UserProfile { UserName = registerDto.UserName, Email = registerDto.Email };
            var createProfile = await _userManager.CreateAsync(userProfile, registerDto.Password);

            if (createProfile.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(userProfile, "User");

                if (roleResult.Succeeded)
                {
                    return Ok(
                        new NewProfileDto
                        {
                            Username = userProfile.UserName,
                            Email = userProfile.Email,
                            Token = _tokenService.CreateToken(userProfile)
                        }
                    );
                }
                else
                    return StatusCode(StatusCodes.Status500InternalServerError, roleResult.Errors);

            }
            else
                return StatusCode(StatusCodes.Status500InternalServerError, createProfile.Errors);

        }
        catch (Exception e)
        {

            return StatusCode(StatusCodes.Status500InternalServerError, e);

        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == loginDto.UserName.ToLower());

        if (user == null) return Unauthorized("Invalid username or password");

        var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

        if (!result.Succeeded) return Unauthorized("Invalid username or password");

        return Ok(new NewProfileDto
        {
            Id = user.Id,
            Username = user.UserName,
            Email = user.Email,
            Token = _tokenService.CreateToken(user)
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] string id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var userProfile = await _userManager.FindByIdAsync(id);
        if (userProfile == null) return NotFound("User not found");

        var userDto = userProfile.ToUserDto(_imageService.GetImageBaseUrl());

        userDto.Followers = await _context.Follows.CountAsync(f => f.FolloweeUserId == id);
        userDto.Following = await _context.Follows.CountAsync(f => f.FollowerUserId == id);


        return Ok(userDto);

    }
    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> Update([FromRoute] string id, [FromForm] UpdateProfileDto updateDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var userProfile = await _userManager.FindByIdAsync(id);
        if (userProfile == null) return NotFound("User not found");
        //Get loged in user 
        var authorizedUsername = User.GetUsername();
        var authorizedUserProfile = await _userManager.FindByNameAsync(authorizedUsername);
        //make sure logged in user is updating their profile, you also implement this on the frontend
        if (authorizedUserProfile.Id != id) return Unauthorized();

        string oldImage = userProfile.ProfilePictureName;

        if (updateDto.ProfilePictureFile != null)
        {
            if (updateDto.ProfilePictureFile?.Length > 5 * 1024 * 1024) return BadRequest("File size should not exceed 5MB");

            string[] allowedFileExtensions = [".jpg", ".png", ".jpeg"];
            string createdFileName = await _imageService.SaveFileAsync(updateDto.ProfilePictureFile, allowedFileExtensions);
            updateDto.ProfilePictureName = createdFileName;
            _imageService.DeleteFileAsync(oldImage);
        }

        userProfile.UserName = updateDto.Username ?? userProfile.UserName;
        userProfile.Email = updateDto.Email ?? userProfile.Email;
        userProfile.Bio = updateDto.Bio ?? userProfile.Bio;
        userProfile.Website = updateDto.Website ?? userProfile.Website;
        userProfile.ProfilePictureName = updateDto.ProfilePictureName ?? userProfile.ProfilePictureName;

        var updateResult = await _userManager.UpdateAsync(userProfile);

        if (!updateResult.Succeeded) return StatusCode(StatusCodes.Status500InternalServerError, updateResult.Errors);

        return Ok(userProfile.ToUserDto(_imageService.GetImageBaseUrl()));
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete([FromRoute] string id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var userProfile = await _userManager.FindByIdAsync(id);
        if (userProfile == null) return NotFound("User not found");

        var authorizedUsername = User.GetUsername();
        var authorizedUserProfile = await _userManager.FindByNameAsync(authorizedUsername);

        if (authorizedUserProfile.Id != id) return Unauthorized();

        await _userManager.DeleteAsync(userProfile);

        return Ok();
    }
}