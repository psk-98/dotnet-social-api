using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Message;
using dotnet_social_api.Models;

namespace dotnet_social_api.Mappers
{
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
    }
}