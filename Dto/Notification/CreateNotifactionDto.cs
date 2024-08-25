using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Dto.Notification
{
    public class CreateNotifactionDto
    {
        [Required]
        public NotificationType Type { get; set; }
        [Required]
        public string ToUserProfileId { get; set; }
        [Required]
        public string FromUserProfileId { get; set; }

    }
}