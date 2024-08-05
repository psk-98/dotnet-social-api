using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Comment;

public class CreateCommentDto
{
    public string Body { get; set; } = string.Empty;
}
