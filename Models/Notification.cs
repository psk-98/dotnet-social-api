using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public NotificationType Type { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool HasBeenSeen { get; set; } = false;
        public string ToUserProfileId { get; set; }
        public string FromUserProfileId { get; set; }
        public UserProfile ToUserProfile { get; set; }
        public UserProfile FromUserProfile { get; set; }
    }
}