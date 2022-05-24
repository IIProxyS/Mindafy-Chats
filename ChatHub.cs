using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiChats
{
    public class ChatHub : Hub
    {
        public void Send(String user, String message)
        {
           Clients.All.SendMessage(user,message);
        }
    }
}