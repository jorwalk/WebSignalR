using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebSignalR.Hubs
{
    public class ZipdecodeHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Random()
        {
            Random rnd = new Random();
            int seed = rnd.Next(99); // creates a number between 0 and 51
            Clients.Caller.addRandom(seed);
        }
    }
}