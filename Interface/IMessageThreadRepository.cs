using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface
{
    public interface IMessageThreadRepository
    {
        Task<List<MessageThread>> GetByUserAsync(string userId);
        Task<MessageThread?> GetByIdAsync(int threadId);
        Task<MessageThread> CreateAsync(MessageThread messageThreadModel);
    }
}