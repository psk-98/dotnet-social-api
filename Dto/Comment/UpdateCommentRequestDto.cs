using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment;

public class UpdateCommentRequestDto
{

    [Required]
    [MinLength(1, ErrorMessage = "Content must be at least 1 characters")]
    [MaxLength(5000, ErrorMessage = "Content  cannot be over 5000 characters")]
    public string Body { get; set; } = string.Empty;
}
