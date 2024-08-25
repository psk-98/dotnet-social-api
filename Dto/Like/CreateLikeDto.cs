using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Like;
public class CreateLikeDto
{
    [Required]
    public string UserProfileId { get; set; } = string.Empty;
    public int? PostId { get; set; }
    public int? CommentId { get; set; }

}
