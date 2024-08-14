using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models
{
    public class Like
    {
        public int Id { get; set; }
        public string UserProfileId { get; set; } = string.Empty;
        public UserProfile? UserProfile { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }
        public int? CommentId { get; set; }
        public Comment? Comment { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}