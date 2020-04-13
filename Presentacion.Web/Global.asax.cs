using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Infraestructura.InyeccionDependencia;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Presentacion.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Infraestructura.Transformacion.Configuracion.InicializarMapas();
            this.InitializeDependencyInjection();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Initialize log4net.
            log4net.Config.XmlConfigurator.Configure();
        }

        private void InitializeDependencyInjection()
        {
            var constructor = new ContainerBuilder();
            var configuracion = GlobalConfiguration.Configuration;
            constructor.RegisterApiControllers(Assembly.GetExecutingAssembly());
            constructor.RegisterWebApiFilterProvider(configuracion);
            constructor.RegisterWebApiModelBinderProvider();
            constructor.RegisterModule<ServiceModule>();
            var contenedor = constructor.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contenedor));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(contenedor);
        }
    }
}
