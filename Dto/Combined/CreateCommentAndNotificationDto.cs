using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Comment;
using dotnet_social_api.Dto.Notification;

namespace dotnet_social_api.Dto.Combined
{
    public class CreateCommentAndNotificationDto
    {
        public CreateCommentDto Comment { get; set; }
        public CreateNotifactionDto Notification { get; set; }
    }
}