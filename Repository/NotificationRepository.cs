using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;

namespace dotnet_social_api.Repository;

public class NotificationRepository : INotificationRepository
{
    private readonly ApplicationDBContext _context;
    public NotificationRepository(ApplicationDBContext context)
    {
        _context = context;

    }

    public async Task<Notification> CreateAsync(Notification notificationModel)
    {
        await _context.Notifications.AddAsync(notificationModel);
        await _context.SaveChangesAsync();

        return notificationModel;
    }
}
