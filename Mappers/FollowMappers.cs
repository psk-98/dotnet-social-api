using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Follow;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;

public static class FollowMappers
{
    public static Follow ToFollowFromCreate(this CreateFollowDto followDto, string followeeUserId, string followerUserId)
    {
        return new Follow
        {
            FolloweeUserId = followeeUserId,
            FollowerUserId = followerUserId
        };
    }
}
