using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Repository;

public class MessageThreadRepository : IMessageThreadRepository
{
    private readonly ApplicationDBContext _context;
    public MessageThreadRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<MessageThread> CreateAsync(MessageThread messageThreadModel)
    {
        await _context.MessageThreads.AddAsync(messageThreadModel);
        await _context.SaveChangesAsync();

        return messageThreadModel;
    }

    public async Task<MessageThread?> GetByIdAsync(int threadId)
    {
        var thread = await _context.MessageThreads.Include(t => t.Messages).FirstOrDefaultAsync(t => t.Id == threadId);

        if (thread == null) return null;


        return thread;
    }

    public async Task<List<MessageThread>> GetByUserAsync(string userId)
    {
        var threads = await _context.MessageThreads.Where(t => t.UserOneId == userId || t.UserTwoId == userId).ToListAsync();

        return threads;
    }
}
