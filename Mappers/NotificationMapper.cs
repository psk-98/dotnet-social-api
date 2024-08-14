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
    public static Notification ToNotificationFromCreate(this CreateNotifactionDto notifactionDto,
                                                        UserProfile toUserProfile,
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

    public static Notification ToNotificationDto(this Notification notificationModel)
    {
        return new Notification
        {
            Id = notificationModel.Id,
            Type = notificationModel.Type,
            CreatedOn = notificationModel.CreatedOn,
            IsSeen = notificationModel.IsSeen,
            ToUserProfileId = notificationModel.ToUserProfileId,
            FromUserProfileId = notificationModel.FromUserProfileId
        };
    }

}
