using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Extensions;
using dotnet_social_api.Helpers;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/notification")]
[ApiController]
public class NoticationController : ControllerBase
{
    private readonly INotificationRepository _notificationRepo;
    private readonly UserManager<UserProfile> _userManager;
    private readonly IImageService _imageService;
    public NoticationController(INotificationRepository notificationRepo, UserManager<UserProfile> userManager, IImageService imageService)
    {
        _notificationRepo = notificationRepo;
        _userManager = userManager;
        _imageService = imageService;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetAll([FromQuery] NotificationQueryObject queryObject)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var authorizedUserProfile = await _userManager.FindByNameAsync(username);

        var notifications = await _notificationRepo.GetAllAsync(authorizedUserProfile.Id, queryObject);
        var notifactionDto = notifications.Select(n => n.ToNotificationDto(_imageService.GetImageBaseUrl()));

        return Ok(notifactionDto);
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var notification = await _notificationRepo.UpdateAsync(id);

        if (notification == null) return NotFound("Notification does not exist");

        return Ok(notification.ToNotificationDto(_imageService.GetImageBaseUrl()));

    }
}
