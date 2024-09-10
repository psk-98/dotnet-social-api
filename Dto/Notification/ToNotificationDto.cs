using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Profile;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Dto.Notification;

public class ToNotificationDto
{
    public NotificationType Type { get; set; }
    public UserDto ToUserProfile { get; set; }
    public UserDto FromUserProfileId { get; set; }
}
