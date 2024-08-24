using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Interface;

public interface INotificationRepository
{
    Task<Notification> CreateAsync(Notification notificationModel);
    Task<List<Notification>> GetAllAsync(string id);
    Task<Notification> UpdateAsync(int id);


}
