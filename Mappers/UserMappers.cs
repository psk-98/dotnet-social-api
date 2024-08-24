using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class UserMappers
{
    public static UserDto ToUserDto(this UserProfile userModel)
    {
        return new UserDto
        {
            Id = userModel.Id,
            Username = userModel.UserName
        };
    }
}
