using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment;

public class UpdateCommentRequestDto
{

    // [Required]
    // [MinLength(5, ErrorMessage = "Content must be at least 5 characters")]
    // [MaxLength(280, ErrorMessage = "Content  cannot be over 280 characters")]

    public string Body { get; set; } = string.Empty;
}
