using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Server.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string message)
        {
            try
            {
                if (String.IsNullOrEmpty(message))
                    throw new ArgumentNullException(nameof(message));
                else
                {
                    await Clients.All.SendAsync("ReceiveMessage", message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
