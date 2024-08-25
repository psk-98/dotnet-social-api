using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Data;
using dotnet_social_api.Helpers;
using dotnet_social_api.Interface;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;
using Microsoft.EntityFrameworkCore;

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

    public async Task<Notification> UpdateAsync(int id)
    {
        var exisitingNotification = await _context.Notifications.FindAsync(id);
        if (exisitingNotification == null) return null;
        //add validation to check if the user updating if the user the notification was sent to 
        exisitingNotification.IsSeen = true;
        await _context.SaveChangesAsync();

        return exisitingNotification;
    }

    public async Task<List<Notification>> GetAllAsync(string id, NotificationQueryObject queryObject)
    {
        var notifications = _context.Notifications.Include(p => p.ToUserProfile).AsQueryable();

        notifications = notifications.Where(p => p.ToUserProfile.Id == id);

        var skipNumber = (queryObject.PageNumber - 1) * queryObject.PageSize;


        return await notifications.Skip(skipNumber).Take(queryObject.PageSize).ToListAsync();
    }
}
