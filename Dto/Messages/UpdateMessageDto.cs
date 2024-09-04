using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Messages;

public class UpdateMessageDto
{
    public string Id { get; set; }
    public string Body { get; set; }
    public bool IsSeen { get; set; } = false;

}