using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Models
{
    public class MessageThread
    {
        public int Id { get; set; }
        public string UserOneId { get; set; }
        public string UserTwoId { get; set; }
        public UserProfile UserProfileOne { get; set; }
        public UserProfile UserProfileTwo { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}