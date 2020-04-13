using Microsoft.AspNet.SignalR;

namespace Presentacion.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void EnviarMensajeGlobal(string mensaje)
        {
            Clients.All.MensajeGlobal(mensaje);
        }
    }
}