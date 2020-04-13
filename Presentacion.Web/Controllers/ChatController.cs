using Presentacion.Web.Hubs;
using System.Web.Http;
using Microsoft.AspNet.SignalR;

namespace Presentacion.Web.Controllers
{
    public class ChatController : ApiController
    {
        private readonly IHubContext<ChatHub> hubContext;
    }
}
