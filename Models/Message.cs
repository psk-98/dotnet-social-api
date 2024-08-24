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
    public string ToUserProfileId { get; set; } = string.Empty;
    public string FromUserProfileId { get; set; } = string.Empty;
    public UserProfile? ToUserProfile { get; set; }
    public UserProfile? FromUserProfile { get; set; }
    public int MessageThreadId { get; set; }
    public MessageThread? MessageThread { get; set; }
}
