using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;


[Route("api/post")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostRepository _postRepo;
    private readonly UserManager<UserProfile> _userManager;
    public PostController(IPostRepository postRepo, UserManager<UserProfile> userManager)
    {
        _postRepo = postRepo;
        _userManager = userManager;
    }
}
