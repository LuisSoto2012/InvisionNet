using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Presentacion.Web.Startup))]

namespace Presentacion.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr",map=>
                {
                    map.UseCors(CorsOptions.AllowAll);
                    var hubConfiguration = new HubConfiguration();
                    hubConfiguration.EnableDetailedErrors = true;
                    map.RunSignalR(hubConfiguration);
                });
        }
    }
}
