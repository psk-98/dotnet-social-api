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


    public async Task<List<Post>> GetAllAsync()
    {
        return await _context.Posts.Include(p => p.UserProfile).ToListAsync();
    }
}
