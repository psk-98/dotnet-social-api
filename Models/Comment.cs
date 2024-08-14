using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string UserProfileId { get; set; } = string.Empty;
        public UserProfile? UserProfile { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }

    }
}