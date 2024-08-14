using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface;

public interface ILikeRepository
{
    Task<Like> CreateAsync(Like likeModel);
    Task<Like> DeleteAsync(int id);
}
