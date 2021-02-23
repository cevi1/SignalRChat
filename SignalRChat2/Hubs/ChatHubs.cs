using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat2.Hubs
{
    public class ChatHubs :Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
