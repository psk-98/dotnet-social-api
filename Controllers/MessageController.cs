using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Dto.Messages;
using dotnet_social_api.Dto.MessageThread;
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
    private readonly IMessageThreadRepository _messageThreadRepo;
    public MessageController(UserManager<UserProfile> userManager, IMessageRepository messageRepo, IMessageThreadRepository messageThreadRepo)
    {
        _messageRepo = messageRepo;
        _userManager = userManager;
        _messageThreadRepo = messageThreadRepo;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMessageDto createMessageDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var username = User.GetUsername();
        var senderUserProfile = await _userManager.FindByNameAsync(username);
        if (createMessageDto.MessageThreadId == -1)
        {
            var createMessageThreadDto = new CreateMessageThreadDto
            {
                UserOneId = senderUserProfile.Id,
                UserTwoId = createMessageDto.RecipientUserId
            };
            var threadModel = createMessageThreadDto.ToThreadFromCreate();
            var result = await _messageThreadRepo.CreateAsync(threadModel);
            Console.Write(createMessageDto);
            Console.Write("next is the creating msg");

            var messageModelTemp = createMessageDto.ToMessageFromCreateNewThread(senderUserProfile.Id, result.Id);
            await _messageRepo.CreateAsync(messageModelTemp);

            return Ok(messageModelTemp);
        }

        var messageModel = createMessageDto.ToMessageFromCreate(senderUserProfile.Id);
        await _messageRepo.CreateAsync(messageModel);

        return Created();
    }

    [HttpPut]
    [Route("{Id:int}")]
    public async Task<IActionResult> Update([FromRoute] int Id, UpdateMessageDto updateMessageDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var message = await _messageRepo.UpdateAsync(Id, updateMessageDto.ToMessageFromUpdate());

        if (message == null) return NotFound("Message not found");

        return Ok(message.ToMessageDto());
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var message = await _messageRepo.DeleteAsync(id);

        if (message == null) return NotFound("Message not found");

        return Ok(message);
    }
}
