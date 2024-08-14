using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;

namespace dotnet_social_api.Repository;

public class LikeRepository : ILikeRepository
{
    private readonly ApplicationDBContext _context;
    public LikeRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    public Task<Like> CreateAsync(Like likeModel)
    {
        throw new NotImplementedException();
    }

    public Task<Like> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
