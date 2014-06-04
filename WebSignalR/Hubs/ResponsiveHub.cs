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
        
        public void MyWebClient()
        {
            var client = new WebClient();
            var downloadString = client.DownloadString("http://www.jordanwalker.net");
            Clients.All.webClient(downloadString);
        }

        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }

        public void MyGeo(string timestamp, decimal latitude)
        {
           Clients.All.setLatitudeLongitude(timestamp, latitude);
        }


    }
}