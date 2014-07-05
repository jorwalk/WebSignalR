using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace WebSignalR.Hubs
{

    public class ResponsiveHub : Hub
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
            Clients.All.addNewMessageToPage(name, message);
        }

        public void MyGeo(string timestamp, int accuracy, decimal latitude, decimal longitude)
        {
            Clients.All.setLatitudeLongitude(timestamp, accuracy, latitude, longitude);
        }


    }
}