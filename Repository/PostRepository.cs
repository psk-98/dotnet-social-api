using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Helpers;
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

    public async Task<Post> DeleteAsync(int id)
    {
        var postModel = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);

        if (postModel == null) return null;

        _context.Posts.Remove(postModel);
        await _context.SaveChangesAsync();

        return postModel;

    }

    public async Task<List<Post>> GetAllAsync(PostQueryObject queryObject)
    {
        var posts = _context.Posts.Include(p => p.UserProfile).AsQueryable();

        if (!string.IsNullOrWhiteSpace(queryObject.Following))
        {
            var followedUsers = _context.Follows.Where(fu => fu.FollowerUserId == queryObject.Following).Select(f => f.FolloweeUserId);
            posts = posts.Where(p => followedUsers.Contains(p.UserProfileId));
        }

        if (!string.IsNullOrWhiteSpace(queryObject.Username))
        {
            posts = posts.Where(p => p.UserProfile.UserName == queryObject.Username);
        }

        var skipNumber = (queryObject.PageNumber - 1) * queryObject.PageSize;

        return await posts.Skip(skipNumber).Take(queryObject.PageSize).ToListAsync();
    }

    public async Task<Post?> GetByIdAsync(int id)
    {
        return await _context.Posts.Include(u => u.UserProfile).FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<bool> PostExists(int id)
    {
        return _context.Posts.AnyAsync(s => s.Id == id);
    }

    public async Task<Post?> UpdateAsync(int id, Post postModel)
    {
        var existingPost = await _context.Posts.FindAsync(id);

        if (existingPost == null) return null;

        existingPost.Body = postModel.Body;

        await _context.SaveChangesAsync();

        return existingPost;
    }

    public async Task<int> GetCommentCountAsync(int postId)
    {
        return await _context.Comments.CountAsync(c => c.PostId == postId);
    }

    public async Task<int> GetLikeCountAsync(int postId)
    {
        return await _context.Likes.CountAsync(l => l.PostId == postId);
    }
}
