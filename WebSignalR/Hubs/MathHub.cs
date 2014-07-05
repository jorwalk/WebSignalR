using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace WebSignalR.Hubs
{
    public class MathHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public async Task JoinRoom(string roomName)
        {
            await Groups.Add(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " joined.");
        }

        public async Task LeaveRoom(string roomName)
        {
            await Groups.Remove(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity + " left.");
            
        }

        public void Add(int a, int b)
        {
            var sum = a + b;
            Clients.All.returnAdd(sum);
        }

        public void CreateRandomTwoDigits()
        {
            var rand = new Random();
            var a = rand.Next(99);
            var b = rand.Next(99);
            Clients.All.showRandomTwoDigits(a, b);
        }
    }
}