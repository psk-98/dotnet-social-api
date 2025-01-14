using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class UserMappers
{
    public static UserDto ToUserDto(this UserProfile userModel, string baseImageUrl)
    {
        return new UserDto
        {
            Id = userModel.Id,
            Username = userModel.UserName,
            Bio = userModel.Bio,
            Website = userModel.Website,
            DateJoined = userModel.DateJoined,
            ProfilePictureName = userModel.ProfilePictureName,
            ProfilePictureUrl = $"{baseImageUrl}/{userModel.ProfilePictureName}"
        };
    }

    // public static UserForPostCommentDto ToUserForPostCommentDto(this UserProfile userModel)
    // {
    //     return new UserForPostCommentDto
    //     {
    //         Id = userModel.Id,
    //         Username = userModel.UserName
    //     };
    // }
}
