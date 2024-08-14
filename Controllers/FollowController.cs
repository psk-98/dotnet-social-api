using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Follow;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/follow")]
[ApiController]
public class FollowController : ControllerBase
{
    private readonly UserManager<UserProfile> _userManager;
    private readonly IFollowRepository _followRepo;

    public FollowController(UserManager<UserProfile> userManager, IFollowRepository followRepo)
    {
        _followRepo = followRepo;
        _userManager = userManager;
    }

    [HttpPost("{username:string}")]
    [Authorize]
    public async Task<IActionResult> Create([FromRoute] string username, CreateFollowDto followDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var followerUsername = User.GetUsername();
        var followerUserProfile = await _userManager.FindByNameAsync(followerUsername);

        var followeeUserProfile = await _userManager.FindByNameAsync(username);
        if (followeeUserProfile == null) return BadRequest("User not found");

        var followModel = followDto.ToFollowFromCreate(followeeUserProfile.Id, followerUserProfile.Id);
        await _followRepo.CreateAsync(followModel);

        return Created();
    }

    [HttpDelete("followId:int")]
    [Authorize]
    public async Task<IActionResult> Delete([FromRoute] int followId)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var followModel = await _followRepo.DeleteAsync(followId);

        if (followModel == null) return NotFound("Follow not found");

        return Ok(followModel);
    }

    //still need to implement get by user id to verify a follow and get all for filtering following and followers


}
