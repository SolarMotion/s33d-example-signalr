using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

using static WebApi.Helpers.Log;

namespace WebApi.Hubs
{
    public class BookingHub : Hub
    {
        public override Task OnDisconnected(bool stopCalled)
        {
            if (stopCalled)
            {
                HubInfo(String.Format("Client {0} explicitly closed the connection.", Context.ConnectionId));
            }
            else
            {
                HubInfo(String.Format("Client {0} timed out .", Context.ConnectionId));
            }

            return base.OnDisconnected(stopCalled);
        }

        public void ServerNewBooking(ServerNewBookingModel request)
        {
            HubInfo($"Connection ID={Context.ConnectionId} => ServerNewBooking({request.Floor}, {request.ID}, {request.CssID}, {request.Status})");

            Clients.All.clientNewBooking(request);
        }

        public class ServerNewBookingModel
        {
            public string Floor { get; set; }
            public int ID { get; set; }
            public string CssID { get; set; }
            public string Status { get; set; }
        }
    }
}