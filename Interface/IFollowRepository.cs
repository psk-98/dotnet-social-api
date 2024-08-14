using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface;

public interface IFollowRepository
{
    Task<Follow> CreateAsync(Follow followModel);
    Task<List<Follow>> GetAllAsync();
    Task<Follow?> DeleteAsync(int followId);
    Task<Follow?> GetByUserIdAsync(string userId);
}
