using Microsoft.AspNetCore.SignalR;
using Publico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Publico.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receiveMessage", message);

        //public async Task GetGmail(string gmail)
        //{
        //    Client client = new Client
        //    {

        //    }
        //}
    }
}
