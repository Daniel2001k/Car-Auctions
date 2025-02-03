using CarAuctions.Server.SignalRHubs;
using CarAuctions.Shared;
using CarAuctions.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CarAuctions.Server.Controllers;


[ApiController]
[AllowAnonymous]
[Route($"api/{Routes.ChatMessage}/[action]")]
public class ChatMessageController(ILogger<ChatMessageController> logger, IHubContext<BroadcastHub> signalR) : ControllerBase
{
    private readonly ILogger<ChatMessageController> _logger = logger;
    private readonly IHubContext<BroadcastHub> _signalR = signalR;

    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] ChatMessage chatMessage)
    {
		try
        {
            await _signalR.Clients.All.SendAsync(ChatHubRoutes.ChatMethod, chatMessage);
            return Ok();
        }
		catch (Exception ex)
        {
            _logger.LogError("Exception - \n\tType: {type}\n\tMessage: {message}", ex.GetType(), ex.Message);
            return BadRequest(ex.Message);
        }
    }
}
