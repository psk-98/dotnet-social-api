using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models;

public class Follow
{
    public int Id { get; set; }
    [ForeignKey("Follower")]
    public string FollowerUserId { get; set; } = string.Empty;
    public UserProfile? FollowerUserProfile { get; set; }
    [ForeignKey("Followee")]
    public string FolloweeUserId { get; set; } = string.Empty;
    public UserProfile? FolloweeUserProfile { get; set; }

}
