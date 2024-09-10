using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Post;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class PostMapper
{
    public static PostDto ToPostDto(this Post postModel, int commentCount, int likeCount)
    {
        return new PostDto
        {
            Id = postModel.Id,
            Body = postModel.Body,
            CreatedOn = postModel.CreatedOn,
            CreatedBy = postModel.UserProfile != null ? postModel.UserProfile.ToUserDto() : null,
            LikeCount = likeCount,
            CommentCount = commentCount

        };
    }

    public static Post ToPostFromCreate(this CreatePostDto postDto)
    {
        return new Post
        {
            Body = postDto.Body
        };
    }

    public static Post ToPostFromUpdate(this UpdatePostDto postDto)
    {
        return new Post
        {
            Body = postDto.Body
        };
    }
}
