using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;
[Route("api/thread")]
[ApiController]

public class MessageThreadController : ControllerBase
{
    private readonly IMessageThreadRepository _threadRepo;
    private readonly UserManager<UserProfile> _userManager;
    public MessageThreadController(IMessageThreadRepository threadRepo, UserManager<UserProfile> userManager)
    {
        _threadRepo = threadRepo;
        _userManager = userManager;
    }
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetByUser()
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var loginedInUser = await _userManager.FindByNameAsync(username);
        if (loginedInUser == null) return BadRequest("User not found");

        var messageThreads = await _threadRepo.GetByUserAsync(loginedInUser.Id);

        var threadsDto = messageThreads.Select(t => t.ToThreadDto());

        return Ok(threadsDto);

    }
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var loginedInUser = await _userManager.FindByNameAsync(username);
        if (loginedInUser == null) return BadRequest("User not found");


        var messageThread = await _threadRepo.GetByIdAsync(id);
        if (messageThread == null) return NotFound("Thread not found");

        if (messageThread.UserOneId != loginedInUser.Id || messageThread.UserTwoId != loginedInUser.Id) return Unauthorized();

        var threadDto = messageThread.ToThreadDto();

        return Ok(threadDto);
    }
}
