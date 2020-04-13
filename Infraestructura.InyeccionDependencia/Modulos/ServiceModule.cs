using Autofac;
using Servicios.Implementacion.Adicional;
using Servicios.Implementacion.Aplicacion;
using Servicios.Implementacion.Archivo;
using Servicios.Implementacion.Atencion;
using Servicios.Implementacion.AtencionTrabajor;
using Servicios.Implementacion.BonoDesempeno;
using Servicios.Implementacion.Comunes;
using Servicios.Implementacion.Congreso;
using Servicios.Implementacion.Laboratorio;
using Servicios.Implementacion.Medico;
using Servicios.Implementacion.Modulo;
using Servicios.Implementacion.OrdenMedica;
using Servicios.Implementacion.Paciente;
using Servicios.Implementacion.Reporte;
using Servicios.Implementacion.Seguridad;
using Servicios.Implementacion.Servicios;
using Servicios.Implementacion.SubModulo;
using Servicios.Implementacion.Ticket;
using Servicios.Interfaces.Adicional;
using Servicios.Interfaces.Aplicacion;
using Servicios.Interfaces.Archivo;
using Servicios.Interfaces.Atencion;
using Servicios.Interfaces.AtencionTrabajador;
using Servicios.Interfaces.BonoDesempeno;
using Servicios.Interfaces.Comunes;
using Servicios.Interfaces.Congreso;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Medico;
using Servicios.Interfaces.Modulo;
using Servicios.Interfaces.OrdenMedica;
using Servicios.Interfaces.Paciente;
using Servicios.Interfaces.Reporte;
using Servicios.Interfaces.Seguridad.Rol;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Servicios;
using Servicios.Interfaces.SubModulo;
using Servicios.Interfaces.Ticket;
using Servicios.Interfaces.Usuario;

namespace Infraestructura.InyeccionDependencia
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GestorDeUsuarios>().As<IGestorDeUsuarios>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeToken>().As<IGestorDeToken>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeRoles>().As<IGestorDeRoles>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeAplicaciones>().As<IGestorDeAplicaciones>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeComunes>().As<IGestorDeComunes>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeModulos>().As<IGestorDeModulos>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeSubModulos>().As<IGestorDeSubModulos>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeMedicos>().As<IGestorDeMedicos>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeServicios>().As<IGestorDeServicios>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDePacientes>().As<IGestorDePacientes>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeAdicionales>().As<IGestorDeAdicionales>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeTomaMuestra>().As<IGestorDeTomaMuestra>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeProcesoAnalitico>().As<IGestorDeProcesoAnalitico>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeReportes>().As<IGestorDeReportes>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDePedidosAnalisis>().As<IGestorDePedidosAnalisis>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeTranscripcionResultados>().As<IGestorDeTranscripcionResultados>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeIndicadoresGestion>().As<IGestorDeIndicadoresGestion>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeArchivos>().As<IGestorDeArchivos>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeAtenciones>().As<IGestorDeAtenciones>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeTickets>().As<IGestorDeTickets>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeOrdenesMedicas>().As<IGestorDeOrdenesMedicas>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeCongreso>().As<IGestorDeCongreso>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeBonoDesempeno>().As<IGestorDeBonoDesempeno>().InstancePerLifetimeScope();
            builder.RegisterType<GestorDeAtencionesTrabajadores>().As<IGestorDeAtencionesTrabajadores>().InstancePerLifetimeScope();
        }
    }
}
