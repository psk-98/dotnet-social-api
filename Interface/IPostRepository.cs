using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(int id);
        Task<Post> CreateAsync(Post postModel);
        Task<Post> UpdateAsync(int id, Post postModel);
        Task<Post> DeleteAsync(int id);
        Task<bool> PostExists(int id);
    }
}