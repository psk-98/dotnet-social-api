using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.MessageThread;
using dotnet_social_api.Models;


namespace dotnet_social_api.Mappers;

public static class ThreadMapper
{
    public static MessageThreadDto ToThreadDto(this MessageThread threadModel)
    {
        return new MessageThreadDto
        {
            Id = threadModel.Id,
            // Messages = threadModel.Messages.Select(m => m.ToMessageDto()).ToList(),
            // LastMessage = threadModel.Messages.OrderByDescending(m => m.CreatedOn).FirstOrDefault()?.ToMessageDto()
            Messages = threadModel.Messages,
            LastMessage = threadModel.Messages.LastOrDefault()
        };
    }
}
