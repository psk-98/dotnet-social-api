using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;

namespace dotnet_social_api.Dto.Post;

public class PostDto
{
    public int Id { get; set; }
    public string Body { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public string CreatedBy { get; set; }
    public int? CommentCount { get; set; }
    public int? LikeCount { get; set; }
}
