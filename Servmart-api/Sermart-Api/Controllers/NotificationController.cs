using Application_Layer.Helpers;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		private readonly IHubContext<NotificationHub> _hubContext;

		public NotificationController( IHubContext<NotificationHub> hubContext )
		{
			_hubContext = hubContext;
		}

		[HttpPost( "sendNotificationToAll" )]
		public async Task<IActionResult> SendNotificationToAll( [FromBody] string message )
		{
			await _hubContext.Clients.All.SendAsync( "ReceiveNotification", message );
			return Ok();
		}

		[HttpPost( "sendNotificationToUser" )]
		public async Task<IActionResult> SendNotificationToUser( string UserId, string Message )
		{
			await _hubContext.Clients.User( UserId ).SendAsync( "ReceiveNotification", Message );
			return Ok();
		}
	}
}
