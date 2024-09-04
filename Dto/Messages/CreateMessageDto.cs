using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Messages;

public class CreateMessageDto
{
    [Required]
    public string Body { get; set; } = string.Empty;
    public int MessageThreadId { get; set; }
    public string RecipientUserId { get; set; }
}
