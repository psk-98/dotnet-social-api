using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
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

    public ProfileController(UserManager<UserProfile> userManager, ITokenService tokenService, SignInManager<UserProfile> signInManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
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
            Username = user.UserName,
            Email = user.Email,
            Token = _tokenService.CreateToken(user)
        });
    }
}