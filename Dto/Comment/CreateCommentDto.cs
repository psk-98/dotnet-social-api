using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Comment;

public class CreateCommentDto
{
    [MaxLength(5000)]
    [Required]
    public string Body { get; set; } = string.Empty;
}
