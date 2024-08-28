using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Message
{
    public class CreateMessageDto
    {
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public int MessageThreadId { get; set; }
    }
}