using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Like;
public class CreateLikeDto
{
    public string UserProfileId { get; set; } = string.Empty;
    public int? PostId { get; set; }
    public int? CommentId { get; set; }

}