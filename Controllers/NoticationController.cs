using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/notification")]
[ApiController]
public class NoticationController : ControllerBase
{
    private readonly INotificationRepository _notificationRepo;
    public NoticationController(INotificationRepository notificationRepo)
    {
        _notificationRepo = notificationRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var notifications = await _notificationRepo.GetAllAsync();
        var notifactionDto = notifications.Select(n => n.ToNotificationDto());

        return Ok(notifactionDto);
    }
}
