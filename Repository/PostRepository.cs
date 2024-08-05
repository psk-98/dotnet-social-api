using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Repository;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDBContext _context;
    public PostRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<Post> CreateAsync(Post postModel)
    {
        await _context.Posts.AddAsync(postModel);
        await _context.SaveChangesAsync();
        return postModel;
    }

    public async Task<List<Post>> GetAllAsync()
    {
        return await _context.Posts.Include(p => p.UserProfile).ToListAsync();
    }

    public async Task<Post> GetByIdAsync(int id)
    {
        return await _context.Posts.Include(u => u.UserProfile).FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<bool> PostExists(int id)
    {
        return _context.Posts.AnyAsync(s => s.Id == id);
    }
}
