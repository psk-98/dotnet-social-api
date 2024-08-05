using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Post;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class PostMapper
{
    public static PostDto ToPostDto(this Post postModel)
    {
        return new PostDto
        {
            Id = postModel.Id,
            Body = postModel.Body,
            CreatedOn = postModel.CreatedOn,
            UserProfileId = postModel.UserProfileId
        };
    }

    public static Post ToPostFromCreate(this CreatePostDto postDto)
    {
        return new Post
        {
            Body = postDto.Body
        };
    }
}
