using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Dto.Follow;

public class CreateFollowDto
{
    public string FollowerUserId { get; set; } = string.Empty;
    public string FolloweeUserId { get; set; } = string.Empty;

}
