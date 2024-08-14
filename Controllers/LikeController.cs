using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Like;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/like")]
[ApiController]
public class LikeController : ControllerBase
{
    private readonly ILikeRepository _likeRepo;
    private readonly UserManager<UserProfile> _userManager;
    public LikeController(ILikeRepository likeRepo, UserManager<UserProfile> userManager)
    {
        _likeRepo = likeRepo;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateLikeDto likeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var userProfile = await _userManager.FindByNameAsync(username);

        var likeModel = likeDto.ToLikeFromCreate();

        await _likeRepo.CreateAsync(likeModel);

        return Created();
    }
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var likeModel = await _likeRepo.DeleteAsync(id);

        if (likeModel == null) return NotFound("Like not found");

        return Ok(likeModel);
    }
}
