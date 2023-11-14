using Microsoft.AspNetCore.SignalR;

namespace Application_Layer.Helpers
{
	public class NotificationHub : Hub
	{

		public async Task SendNotificationToAll( string message )
		{
			await Clients.All.SendAsync( "ReceiveNotification", message );
		}

		public async Task SendNotificationToUser( string userId, string message )
		{
			await Clients.Client( userId ).SendAsync( "ReceiveNotification", message );
		}

		public override async Task OnConnectedAsync()
		{
			await base.OnConnectedAsync();
		}

		public override async Task OnDisconnectedAsync( Exception exception )
		{
			await base.OnDisconnectedAsync( exception );
		}
	}
}
