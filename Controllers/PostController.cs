using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Post;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
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

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var posts = await _postRepo.GetAllAsync();
        var postDto = posts.Select(p => p.ToPostDto());

        return Ok(postDto);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var post = await _postRepo.GetByIdAsync(id);
        if (post == null) return NotFound();

        var postDto = post.ToPostDto();

        return Ok(postDto);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePostDto postDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var userProfile = await _userManager.FindByNameAsync(username);

        var postModel = postDto.ToPostFromCreate();
        postModel.UserProfileId = userProfile.Id;
        await _postRepo.CreateAsync(postModel);

        return CreatedAtAction(nameof(GetById), new { id = postModel.Id }, postModel.ToPostDto());
    }
}
