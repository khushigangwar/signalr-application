
using Microsoft.AspNetCore.SignalR;

namespace signalr_application.Hubs
{
    public class ChatHub :Hub
    {
        public async Task SendMessageToAll(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

