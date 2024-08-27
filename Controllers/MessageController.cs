using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Interface;
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

    [HttpPost]
}
