using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace GraduationProject.SignalR.Hubs
{
    public class NewsFeedHub : Hub
    {
        public void NewQuestion()
        {
            Clients.Client("").addQuestion();
        }
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}