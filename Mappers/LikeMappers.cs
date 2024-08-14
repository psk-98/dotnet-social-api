using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Like;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class LikeMappers
{
    public static Like ToLikeFromCreate(this CreateLikeDto likeDto)
    {
        return new Like
        {
            UserProfileId = likeDto.UserProfileId,
            PostId = likeDto.PostId,
            CommentId = likeDto.CommentId
        };
    }
}
