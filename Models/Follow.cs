using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public string UserProfileId { get; set; } = string.Empty;
        public string FollowedUserId { get; set; } = string.Empty;
        public UserProfile UserProfile { get; set; }
        public UserProfile FollowedUserProfile { get; set; }

    }
}