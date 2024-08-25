using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Post
{
    public class UpdatePostDto
    {
        [MaxLength(5000, ErrorMessage = "Body cannot be over 5000 characters")]
        public string Body { get; set; } = string.Empty;
    }
}