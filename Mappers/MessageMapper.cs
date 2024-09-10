using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Messages;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers;
public static class MessageMapper
{
    public static Message ToMessageFromCreate(this CreateMessageDto createMessageDto, string senderUserProfileId)
    {
        return new Message
        {
            SenderUserProfileId = senderUserProfileId,
            Body = createMessageDto.Body,
            MessageThreadId = createMessageDto.MessageThreadId
        };
    }
    public static Message ToMessageFromCreateNewThread(this CreateMessageDto createMessageDto, string senderUserProfileId, int messageThreadId)
    {
        return new Message
        {
            SenderUserProfileId = senderUserProfileId,
            Body = createMessageDto.Body,
            MessageThreadId = messageThreadId
        };
    }
    public static Message ToMessageFromUpdate(this UpdateMessageDto updateMessageDto)
    {
        return new Message
        {
            Body = updateMessageDto.Body,
            IsSeen = updateMessageDto.IsSeen
        };
    }

    public static MessageDto ToMessageDto(this Message messageModel)
    {
        return new MessageDto
        {
            Id = messageModel.Id,
            Body = messageModel.Body,
            CreatedOn = messageModel.CreatedOn,
            SenderUserProfile = messageModel.SenderUserProfile.ToUserDto(),
            IsSeen = messageModel.IsSeen,
        };
    }
}


