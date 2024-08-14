using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Repository;

public class FollowRepository : IFollowRepository
{
    private readonly ApplicationDBContext _context;
    public FollowRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<Follow> CreateAsync(Follow followModel)
    {
        await _context.Follows.AddAsync(followModel);
        await _context.SaveChangesAsync();

        return followModel;
    }

    public async Task<Follow?> DeleteAsync(int followId)
    {
        var followModel = await _context.Follows.FirstOrDefaultAsync(f => f.Id == followId);

        if (followModel == null) return null;

        _context.Follows.Remove(followModel);
        await _context.SaveChangesAsync();

        return followModel;
    }

    public Task<List<Follow>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Follow?> GetByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
