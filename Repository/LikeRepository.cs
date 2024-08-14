using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Repository;

public class LikeRepository : ILikeRepository
{
    private readonly ApplicationDBContext _context;
    public LikeRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task<Like> CreateAsync(Like likeModel)
    {
        await _context.Likes.AddAsync(likeModel);
        await _context.SaveChangesAsync();

        return likeModel;
    }

    public async Task<Like> DeleteAsync(int id)
    {
        var likeModel = await _context.Likes.FirstOrDefaultAsync(l => l.Id == id);

        if (likeModel == null) return null;

        _context.Likes.Remove(likeModel);
        await _context.SaveChangesAsync();

        return likeModel;
    }
}
