using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;
[Route("api/thread")]
[ApiController]

public class ThreadController : ControllerBase
{
    private readonly IThreadRepository _threadRepo;
    private readonly UserManager<UserProfile> _userManager;
    public ThreadController(IThreadRepository threadRepo, UserManager<UserProfile> userManager)
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
        var threads = await _threadRepo.GetByUserAsync(loginedInUser.Id);
    }
    // get all threads, and get by id 
}
