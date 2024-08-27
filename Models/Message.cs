using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models;

public class Message
{
    public int Id { get; set; }
    public string Body { get; set; } = string.Empty;
    public bool IsSeen { get; set; } = false;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public string SenderUserProfileId { get; set; } = string.Empty;
    public UserProfile? SenderUserProfile { get; set; }
    public int ThreadId { get; set; }
    public Thread? Thread { get; set; }
}
