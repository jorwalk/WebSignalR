using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace WebSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            var version = Context.QueryString["version"];
            if (version != "1.0")
            {
                Clients.Caller.notifyWrongVersion();
            }
            return base.OnConnected();
        }

        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}