using AutoMapper;
using Dominio.Entidades;
using Dominio.Entidades.Comunes;
using Dominio.Entidades.LaboratorioInmunologico;
using Servicios.Interfaces.Aplicacion.Peticiones;
using Servicios.Interfaces.Aplicacion.Respuestas;
using Servicios.Interfaces.Archivo.Peticiones;
using Servicios.Interfaces.Atencion.Respuestas;
using Servicios.Interfaces.AtencionTrabajador.Peticiones;
using Servicios.Interfaces.AtencionTrabajador.Respuestas;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Comunes;
using Servicios.Interfaces.Comunes.Respuestas;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using Servicios.Interfaces.Modulo.Peticiones;
using Servicios.Interfaces.Modulo.Respuestas;
using Servicios.Interfaces.OrdenMedica.Peticiones;
using Servicios.Interfaces.OrdenMedica.Respuestas;
using Servicios.Interfaces.Reporte.Respuestas;
using Servicios.Interfaces.Seguridad.Rol.Peticiones;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using Servicios.Interfaces.SubModulo.Peticiones;
using Servicios.Interfaces.SubModulo.Respuestas;
using Servicios.Interfaces.Ticket;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;
using System;
using System.Globalization;
using System.Linq;

namespace Infraestructura.Transformacion
{
    public class Configuracion
    {
        public static void InicializarMapas()
        {
            Mapper.Initialize(configuration => {
                //Empleado
                configuration.CreateMap<NuevoEmpleado, Empleado>()
                             .ForMember(p => p.IdCondicionTrabajo, x => x.MapFrom(p => p.CondicionTrabajo.Id))
                             .ForMember(p => p.IdTipoEmpleado, x => x.MapFrom(p => p.TipoEmpleado.Id))
                             .ForMember(p => p.IdTipoDocumento, x => x.MapFrom(p => p.TipoDocumentoIdentidad.Id));
                configuration.CreateMap<ActualizarEmpleado, Empleado>()
                             .ForMember(p => p.IdCondicionTrabajo, x => x.MapFrom(p => p.CondicionTrabajo.Id))
                             .ForMember(p => p.IdTipoEmpleado, x => x.MapFrom(p => p.TipoEmpleado.Id))
                             .ForMember(p => p.IdTipoDocumento, x => x.MapFrom(p => p.TipoDocumentoIdentidad.Id));
                configuration.CreateMap<Empleado, UsuarioLogin>()
                             .ForMember(r => r.FechaNacimiento, x => x.MapFrom(p => p.FechaNacimiento.Equals(default(DateTime)) ? string.Empty : p.FechaNacimiento.ToString("dd/MM")));
                configuration.CreateMap<EmpleadoGeneral, Empleado>();
                configuration.CreateMap<Empleado, EmpleadoGeneral>();
                //Incidentes
                configuration.CreateMap<IncidentesPacientesGeneral, IncidentesPacientes>();
                configuration.CreateMap<IncidentesPacientes, IncidentesPacientesGeneral>();
                //Rol
                configuration.CreateMap<NuevoRol, Rol>();
                configuration.CreateMap<ActualizarRol, Rol>();
                configuration.CreateMap<Rol, RolGeneral>();
                configuration.CreateMap<RolGeneral, Rol>();
                //Aplicacion
                configuration.CreateMap<NuevaAplicacion, Aplicacion>();
                configuration.CreateMap<ActualizarAplicacion, Aplicacion>();
                configuration.CreateMap<Aplicacion, AplicacionGeneral>();
                configuration.CreateMap<AplicacionGeneral, Aplicacion>();
                //Combos
                configuration.CreateMap<CondicionTrabajo, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdCondicionTrabajo));
                configuration.CreateMap<TipoEmpleado, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdTipoEmpleado));
                configuration.CreateMap<TipoDocumentoIdentidad, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdTipoDocumentoIdentidad));
                configuration.CreateMap<AreaLaboratorio, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdAreaLaboratorio))
                             .ForMember(p => p.Descripcion, x => x.MapFrom(p => p.Nombre));
                configuration.CreateMap<PruebaLaboratorio, ComboBox>()
                             .ForMember(p => p.Descripcion, x => x.MapFrom(p => p.Nombre));
                configuration.CreateMap<Empleado, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdEmpleado))
                             .ForMember(p => p.Descripcion, x => x.MapFrom(p => string.Concat(p.ApellidoPaterno, " ", p.ApellidoMaterno, ", ", p.Nombres)));
                configuration.CreateMap<OpcionesOrdenMedica, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdOpcionOrdenMedica));
                configuration.CreateMap<OpcionesOrdenMedica, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdOpcionOrdenMedica));
                configuration.CreateMap<TipoOrdenMedica, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdTipoOrdenMedica));
                configuration.CreateMap<CodigosRespuestaIndicadoresDesempeno, ComboBox>();
                configuration.CreateMap<EscalafonDeLegajos, ComboBox>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdEscalafonDeLegajos))
                             .ForMember(p => p.Descripcion, x => x.MapFrom(p => string.Concat(p.Seccion, " - ", p.Descripcion)));

                configuration.CreateMap<ComboBox, CondicionTrabajo>()
                             .ForMember(p => p.IdCondicionTrabajo, x => x.MapFrom(p => p.Id));
                configuration.CreateMap<ComboBox, TipoEmpleado>()
                             .ForMember(p => p.IdTipoEmpleado, x => x.MapFrom(p => p.Id));
                configuration.CreateMap<ComboBox, TipoDocumentoIdentidad>()
                             .ForMember(p => p.IdTipoDocumentoIdentidad, x => x.MapFrom(p => p.Id));
                configuration.CreateMap<ComboBox, OpcionesOrdenMedica>()
                             .ForMember(p => p.IdOpcionOrdenMedica, x => x.MapFrom(p => p.Id));
                //Modulo
                configuration.CreateMap<NuevoModulo, Modulo>();
                configuration.CreateMap<ActualizarModulo, Modulo>();
                configuration.CreateMap<Modulo, ModuloGeneral>();
                configuration.CreateMap<ModuloGeneral, Modulo>();
                //SubModulo
                configuration.CreateMap<NuevoSubModulo, SubModulo>();
                configuration.CreateMap<ActualizarSubModulo, SubModulo>();
                configuration.CreateMap<SubModulo, SubModuloGeneral>();
                configuration.CreateMap<SubModuloGeneral, SubModulo>();
                //RolSubModulo
                configuration.CreateMap<RolSubModuloDto, RolSubModulo>();
                configuration.CreateMap<RolSubModulo, RolSubModuloDto>();
                //IncidentesPacientes
                configuration.CreateMap<NuevoIncidentesPacientes, IncidentesPacientes>();
                configuration.CreateMap<ActualizarIncidentesPacientes, IncidentesPacientes>();
                configuration.CreateMap<IncidentesPacientes, IncidentesPacientesGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                configuration.CreateMap<IncidentesPacientesGeneral, IncidentesPacientes>();
                //IncumplimientoAnalisis
                configuration.CreateMap<NuevoIncumplimientoAnalisis, IncumplimientoAnalisis>();
                configuration.CreateMap<ActualizarIncumplimientoAnalisis, IncumplimientoAnalisis>();
                configuration.CreateMap<IncumplimientoAnalisis, IncumplimientoAnalisisGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                configuration.CreateMap<IncumplimientoAnalisisGeneral, IncumplimientoAnalisis>();
                //PruebasNoRealizadas
                configuration.CreateMap<NuevoPruebasNoRealizadas, PruebasNoRealizadas>();
                configuration.CreateMap<ActualizarPruebasNoRealizadas, PruebasNoRealizadas>();
                configuration.CreateMap<PruebasNoRealizadas, PruebasNoRealizadasGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                configuration.CreateMap<PruebasNoRealizadasGeneral, PruebasNoRealizadas>();
                //RecoleccionMuestra
                configuration.CreateMap<NuevoRecoleccionMuestra, RecoleccionMuestra>();
                configuration.CreateMap<ActualizarRecoleccionMuestra, RecoleccionMuestra>();
                configuration.CreateMap<RecoleccionMuestra, RecoleccionMuestraGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                configuration.CreateMap<RecoleccionMuestraGeneral, RecoleccionMuestra>();
                //VenopunturasFallidas
                configuration.CreateMap<NuevoVenopunturasFallidas, VenopunturasFallidas>();
                configuration.CreateMap<ActualizarVenopunturasFallidas, VenopunturasFallidas>();
                configuration.CreateMap<VenopunturasFallidas, VenopunturasFallidasGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                configuration.CreateMap<VenopunturasFallidasGeneral, VenopunturasFallidas>();
                //CalibracionDeficiente
                configuration.CreateMap<NuevoCalibracionDeficiente, CalibracionDeficiente>();
                configuration.CreateMap<CalibracionDeficiente, CalibracionDeficienteGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //EmpleoReactivo
                configuration.CreateMap<NuevoEmpleoReactivo, EmpleoReactivo>();
                configuration.CreateMap<EmpleoReactivo, EmpleoReactivoGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //EquipoMalCalibrado
                configuration.CreateMap<NuevoEquipoMalCalibrado, EquipoMalCalibrado>();
                configuration.CreateMap<EquipoMalCalibrado, EquipoMalCalibradoGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //EquipoUPS
                configuration.CreateMap<NuevoEquipoUPS, EquipoUPS>();
                configuration.CreateMap<EquipoUPS, EquipoUPSGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //MaterialNoCalibrado
                configuration.CreateMap<NuevoMaterialNoCalibrado, MaterialNoCalibrado>();
                configuration.CreateMap<MaterialNoCalibrado, MaterialNoCalibradoGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //MuestraHemolizadaLipemica
                configuration.CreateMap<NuevoMuestraHemolizadaLipemica, MuestraHemolizadaLipemica>();
                configuration.CreateMap<MuestraHemolizadaLipemica, MuestraHemolizadaLipemicaGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //PocoFrecuente
                configuration.CreateMap<NuevoPocoFrecuente, PocoFrecuente>();
                configuration.CreateMap<PocoFrecuente, PocoFrecuenteGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //SueroMalReferenciado
                configuration.CreateMap<NuevoSueroMalReferenciado, SueroMalReferenciado>();
                configuration.CreateMap<SueroMalReferenciado, SueroMalReferenciadoGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //SolicitudDatosIncompletos
                configuration.CreateMap<NuevoSolicitudDatosIncompletos, SolicitudDatosIncompletos>();
                configuration.CreateMap<SolicitudDatosIncompletos, SolicitudDatosIncompletosGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                //TranscripcionErronea
                configuration.CreateMap<NuevoTranscripcionErronea, TranscripcionErronea>();
                configuration.CreateMap<TranscripcionErronea, TranscripcionErroneaGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                //TranscripcionErroneaInoportuna
                configuration.CreateMap<NuevoTranscripcionErroneaInoportuna, TranscripcionErroneaInoportuna>();
                configuration.CreateMap<TranscripcionErroneaInoportuna, TranscripcionErroneaInoportunaGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre));
                //SueroMalReferenciado
                configuration.CreateMap<NuevoRendimientoHoraTrabajador, RendimientoHoraTrabajador>();
                configuration.CreateMap<RendimientoHoraTrabajador, RendimientoHoraTrabajadorGeneral>()
                             .ForMember(p => p.NombreMes, x => x.MapFrom(p => p.NumeroMes.Equals(default(DateTime)) ? string.Empty : new DateTime(2020, p.NumeroMes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))))
                             .ForMember(p => p.AreaLaboratorio, x => x.MapFrom(p => p.AreaLaboratorio.Nombre))
                             .ForMember(p => p.FechaCreacion, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("yyyy-MM-dd")));
                //PacienteSinResultado
                configuration.CreateMap<NuevoPacienteSinResultado, PacienteSinResultado>();
                configuration.CreateMap<PacienteSinResultado, PacienteSinResultadoGeneral>()
                             .ForMember(r => r.FechaOcurrencia, x => x.MapFrom(p => p.FechaOcurrencia.Equals(default(DateTime)) ? string.Empty : p.FechaOcurrencia.ToString("yyyy-MM-dd")));
                //Reporte
                configuration.CreateMap<Reporte, ReporteGeneral>();
                //Modulo
                configuration.CreateMap<NuevoArchivo, Archivo>();

                //EquipoUPS
                configuration.CreateMap<AuditoriaGeneral, Auditoria>();
                //TicketConsultaExterna
                configuration.CreateMap<NuevoTicketConsultaExterna, TicketConsultaExterna>();
                configuration.CreateMap<TicketConsultaExterna, TicketConsultaExternaGeneral>()
                             .ForMember(r => r.FechaHora, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("dd/MM/yyyy - HH:mm:ss")));
                //ORDENES MEDICAS
                configuration.CreateMap<NuevaOrdenMedica, OrdenesMedicas>();
                configuration.CreateMap<OrdenesMedicas, OrdenMedicaGeneral>()
                             .ForMember(r => r.FechaRegistro, x => x.MapFrom(p => p.FechaCreacion.Equals(default(DateTime)) ? string.Empty : p.FechaCreacion.ToString("dd/MM/yyyy")))
                             .ForMember(r => r.Fecha, x => x.MapFrom(p => p.Fecha.Equals(default(DateTime)) ? string.Empty : p.Fecha.ToString("yyyy-MM-dd")));

                configuration.CreateMap<NuevaOrdenesMedicasCodigos, OrdenesMedicasCodigos>();
                configuration.CreateMap<OrdenesMedicasCodigos, OrdenesMedicasCodigosGeneral>();

                configuration.CreateMap<TipoOrdenMedica, TipoOrdenMedicaGeneral>()
                             .ForMember(p => p.Id, x => x.MapFrom(p => p.IdTipoOrdenMedica))
                             .ForMember(p => p.Codigo, x => x.MapFrom(p => p.Descripcion.Replace(" ", "")));
                
                //Procedimiento
                configuration.CreateMap<Procedimiento, ProcedimientoDto>();
                //TipoOrdenMedicaRangos
                configuration.CreateMap<TipoOrdenMedicaRangos, TipoOrdenMedicaRangosDto>()
                             .ForMember(p => p.Condicionales, x => x.MapFrom(p => p.Condicionales.Split('|').OfType<string>().ToList()));

                configuration.CreateMap<NuevaAtencionTrabajador, AtencionTrabajador>();
                configuration.CreateMap<AtencionTrabajador, AtencionTrabajadorGeneral>();
            });
        }
    }
}
