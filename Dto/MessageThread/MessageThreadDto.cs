using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Dto.MessageThread;
public class MessageThreadDto
{
    public int Id { get; set; }
    public List<Message> Messages { get; set; } = new List<Message>();
    public Message? LastMessage { get; set; } = null;
}
