using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models
{
    public class MessageThread
    {
        public int Id { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}