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

public class CommentRepository : ICommentRepository
{
    private readonly ApplicationDBContext _context;
    public CommentRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task<Comment> CreateAsync(Comment commentModel)
    {
        await _context.Comments.AddAsync(commentModel);
        await _context.SaveChangesAsync();

        return commentModel;
    }

    public async Task<Comment> DeleteAsync(int id)
    {
        var commentModel = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);

        if (commentModel == null) return null;

        _context.Comments.Remove(commentModel);
        await _context.SaveChangesAsync();

        return commentModel;
    }


    public async Task<List<Comment>> GetAllAsync(CommentQueryObject queryObject)
    {
        var comments = _context.Comments.Include(a => a.UserProfile).AsQueryable();

        if (queryObject.PostId != null)
        {
            comments = comments.Where(c => c.PostId == queryObject.PostId);
        }

        if (!string.IsNullOrWhiteSpace(queryObject.Username))
        {
            comments = comments.Where(c => c.UserProfile.UserName == queryObject.Username);
        }

        var skipNumber = (queryObject.PageNumber - 1) * queryObject.PageSize;

        return await comments.Skip(skipNumber).Take(queryObject.PageSize).ToListAsync();

    }

    public async Task<Comment?> GetByIdAsync(int id)
    {
        return await _context.Comments.Include(a => a.UserProfile).FirstOrDefaultAsync(c => c.Id == id);

    }

    public async Task<Comment> UpdateAsync(int id, Comment commentModel)
    {
        var exisitingComment = await _context.Comments.FindAsync(id);

        if (exisitingComment == null) return null;

        exisitingComment.Body = commentModel.Body;

        await _context.SaveChangesAsync();

        return exisitingComment;
    }

    public async Task<int> GetLikeCountAsync(int commentId)
    {
        return await _context.Likes.CountAsync(l => l.CommentId == commentId);
    }
}
