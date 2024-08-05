using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Notification;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Mappers;

public static class NotificationMapper
{
    public static Notification ToNotificationFromCreate(this CreateNotifactionDto notifactionDto, UserProfile toUserProfile,
                                    UserProfile fromUserProfile,
                                    NotificationType type)
    {
        return new Notification
        {
            Type = type,
            ToUserProfileId = toUserProfile.Id,
            FromUserProfileId = fromUserProfile.Id
        };
    }

}
