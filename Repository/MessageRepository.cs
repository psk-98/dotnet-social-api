using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Repository;

public class MessageRepository : IMessageRepository
{
    private readonly ApplicationDBContext _context;
    public MessageRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<Message> CreateAsync(Message messageModel)
    {
        await _context.Messages.AddAsync(messageModel);
        await _context.SaveChangesAsync();

        return messageModel;
    }

    public async Task<Message> DeleteAsync(int id)
    {
        var messageModel = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);

        if (messageModel == null) return null;

        _context.Messages.Remove(messageModel);
        await _context.SaveChangesAsync();

        return messageModel;
    }



    // public Task<List<Message>> GetAllAsync()
    // {
    //     throw new NotImplementedException();
    // }

    // public Task<Message?> GetByIdAsync(int id)
    // {
    //     throw new NotImplementedException();
    // }

    public async Task<Message> UpdateAsync(int id, Message messageModel)
    {
        var existingMessage = await _context.Messages.FindAsync(id);

        if (existingMessage == null) return null;

        existingMessage.Body = messageModel.Body;
        existingMessage.IsSeen = messageModel.IsSeen;

        await _context.SaveChangesAsync();

        return existingMessage;
    }
}