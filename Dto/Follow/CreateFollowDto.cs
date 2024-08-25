using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Dto.Follow;

public class CreateFollowDto
{
    [Required]
    public string FollowerUserId { get; set; } = string.Empty;
    [Required]
    public string FolloweeUserId { get; set; } = string.Empty;

}
