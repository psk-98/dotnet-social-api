using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Message;
using dotnet_social_api.Extensions;
using dotnet_social_api.Interface;
using dotnet_social_api.Mappers;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/message")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IMessageRepository _messageRepo;
    private readonly UserManager<UserProfile> _userManager;

    public MessageController(UserManager<UserProfile> userManager, IMessageRepository messageRepo)
    {
        _messageRepo = messageRepo;
        _userManager = userManager;
    }

    [HttpPost("{messageThreadId:int}")]

    public async Task<IActionResult> Create([FromRoute] int messageThreadId, CreateMessageDto createMessageDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var senderUserProfile = await _userManager.FindByNameAsync(username);

        var messageModel = createMessageDto.ToMessageFromCreate(senderUserProfile.Id);
    }
}
