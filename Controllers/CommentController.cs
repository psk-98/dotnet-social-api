using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using dotnet_social_api.Dto.Combined;
using dotnet_social_api.Dto.Comment;
using dotnet_social_api.Dto.Notification;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/comment")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly UserManager<UserProfile> _userManager;
    private readonly ICommentRepository _commentRepo;
    private readonly INotificationRepository _notificationRepo;
    private readonly IPostRepository _postRepo;
    public CommentController(UserManager<UserProfile> userManager, ICommentRepository commentRepo, INotificationRepository notificationRepo, IPostRepository postRepo)
    {
        _userManager = userManager;
        _commentRepo = commentRepo;
        _notificationRepo = notificationRepo;
        _postRepo = postRepo;
    }

    [HttpPost("{postId:int}")]
    [Authorize]
    public async Task<IActionResult> Create([FromRoute] int postId, CreateCommentAndNotificationDto combinedDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var currentPostModel = await _postRepo.GetByIdAsync(postId);
        if (currentPostModel == null) return BadRequest("Post does not exist");

        var username = User.GetUsername();
        var fromUserProfile = await _userManager.FindByNameAsync(username);


        var commentModel = combinedDto.Comment.ToCommentFromCreate(postId, fromUserProfile.Id);
        await _commentRepo.CreateAsync(commentModel);

        var notificationModel = combinedDto.Notification.ToNotificationFromCreate(currentPostModel.UserProfile, fromUserProfile, NotificationType.Comment);
        await _notificationRepo.CreateAsync(notificationModel);

        return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.ToCommentDto());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var comment = await _commentRepo.GetByIdAsync(id);

        if (comment == null) return NotFound();

        return Ok(comment.ToCommentDto());
    }

    [HttpGet("post/{postId:int}")]
    public async Task<IActionResult> GetByPostId(int postId)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var comment = await _commentRepo.GetByIdAsync(postId);

        if (comment == null) return NotFound();

        return Ok(comment.ToCommentDto());
    }


    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentRequestDto updateDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var comment = await _commentRepo.UpdateAsync(id, updateDto.ToCommentFromUpdate());

        if (comment == null) return NotFound("Comment not found");

        return Ok(comment.ToCommentDto());
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var commentModel = await _commentRepo.DeleteAsync(id);

        if (commentModel == null) return NotFound("Comment does not exist");

        return Ok(commentModel);

    }

}
