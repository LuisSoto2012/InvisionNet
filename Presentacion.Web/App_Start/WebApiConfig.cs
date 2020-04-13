using Presentacion.Web.ActionFilter;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Routing;

namespace Presentacion.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            //Capturar errores
            config.Filters.Add(new MyExceptionFilter());

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Enable Cors:
            var cors = new EnableCorsAttribute(origins: "*", headers: "*", methods: "*");
            config.EnableCors(cors);
            var constraints = new { httpMethod = new HttpMethodConstraint(HttpMethod.Options) };
            config.Routes.IgnoreRoute("OPTIONS", "*pathInfo", constraints);

        }
    }
}
