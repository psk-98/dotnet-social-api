using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface
{
    public interface IMessageRepository
    {
        Task<Message> CreateAsync(Message message);
        // Task<List<Message>> GetAllAsync();
        // Task<Message?> GetByIdAsync(int id);
        Task<Message> UpdateAsync(int id, Message message);
        Task<Message> DeleteAsync(int id);
    }
}