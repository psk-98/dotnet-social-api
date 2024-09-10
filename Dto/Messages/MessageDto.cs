using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;

namespace dotnet_social_api.Dto.Messages;

public class MessageDto
{
    public int Id { get; set; }
    public string Body { get; set; } = string.Empty;
    public bool IsSeen { get; set; } = false;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public UserDto SenderUserProfile { get; set; }
}
