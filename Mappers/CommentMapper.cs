using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using dotnet_social_api.Dto.Comment;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class CommentMapper
{
    public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int postId, string userId)
    {
        return new Comment
        {
            Body = commentDto.Body,
            PostId = postId,
            UserProfileId = userId
        };
    }

    public static CommentDto ToCommentDto(this Comment commentModel, int likeCount)
    {
        return new CommentDto
        {
            Id = commentModel.Id,
            Body = commentModel.Body,
            CreatedOn = commentModel.CreatedOn,
            CreatedBy = commentModel.UserProfile.UserName,
            PostId = commentModel.PostId,
            LikeCount = likeCount
        };
    }

    public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
    {
        return new Comment
        {
            Body = commentDto.Body,
        };
    }
}
