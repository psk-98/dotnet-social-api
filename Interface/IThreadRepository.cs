using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Interface
{
    public interface IThreadRepository
    {
        Task<List<Thread>> GetByUserAsync(string userId);
        Task<Thread> GetByIdAsync(int threadId);
    }
}