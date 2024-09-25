using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Post;
using dotnet_social_api.Extensions;
using dotnet_social_api.Helpers;
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
    private readonly IImageService _imageService;
    public PostController(IPostRepository postRepo, UserManager<UserProfile> userManager, IImageService imageService)
    {
        _postRepo = postRepo;
        _userManager = userManager;
        _imageService = imageService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PostQueryObject query)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var posts = await _postRepo.GetAllAsync(query);

        var postDtoTasks = posts.Select(async p =>
        {
            var commentCount = await _postRepo.GetCommentCountAsync(p.Id);
            var likeCount = await _postRepo.GetLikeCountAsync(p.Id);


            return p.ToPostDto(commentCount, likeCount, _imageService.GetImageBaseUrl());
        });
        var postsDto = await Task.WhenAll(postDtoTasks);
        return Ok(postsDto);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var post = await _postRepo.GetByIdAsync(id);
        if (post == null) return NotFound();

        var commentCount = await _postRepo.GetCommentCountAsync(id);
        var likeCount = await _postRepo.GetLikeCountAsync(id);

        var postDto = post.ToPostDto(commentCount, likeCount, _imageService.GetImageBaseUrl());

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

        return CreatedAtAction(nameof(GetById), new { id = postModel.Id }, postModel.ToPostDto(0, 0, _imageService.GetImageBaseUrl()));
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePostDto updateDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var postModel = await _postRepo.UpdateAsync(id, updateDto.ToPostFromUpdate());

        if (postModel == null) return NotFound("Post not found");

        var commentCount = await _postRepo.GetCommentCountAsync(id);
        var likeCount = await _postRepo.GetLikeCountAsync(id);

        return Ok(postModel.ToPostDto(commentCount, likeCount, _imageService.GetImageBaseUrl()));
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var postModel = await _postRepo.DeleteAsync(id);

        if (postModel == null) return NotFound("Post does not exist");

        return Ok(postModel);

    }
}
