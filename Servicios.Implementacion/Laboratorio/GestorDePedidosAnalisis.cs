using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Dominio.Entidades.LaboratorioInmunologico;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;

namespace Servicios.Implementacion.Laboratorio
{
    public class GestorDePedidosAnalisis : IGestorDePedidosAnalisis
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD AgregarSolicitudDatosIncompletos(NuevoSolicitudDatosIncompletos nuevoSolicitudDatosIncompletos)
        {
            using (InoBD db = new InoBD())
            {
                SolicitudDatosIncompletos pacienteEncontrado = db.SolicitudDatosIncompletos.Where(x => x.HistoriaClinica == nuevoSolicitudDatosIncompletos.HistoriaClinica && x.FechaOcurrencia == nuevoSolicitudDatosIncompletos.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    SolicitudDatosIncompletos solicitudDatosIncompletos = Mapper.Map<SolicitudDatosIncompletos>(nuevoSolicitudDatosIncompletos);
                    db.SolicitudDatosIncompletos.Add(solicitudDatosIncompletos);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = solicitudDatosIncompletos.IdSolicitudDatosIncompletos;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "SolicitudDatosIncompletos",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoSolicitudDatosIncompletos),
                        IdUsuario = nuevoSolicitudDatosIncompletos.IdUsuarioCreacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                }

                return respuesta;
            }
        }

        public RespuestaBD AgregarTranscripcionErronea(NuevoTranscripcionErronea nuevoTranscripcionErronea)
        {
            using (InoBD db = new InoBD())
            {
                TranscripcionErronea pacienteEncontrado = db.TranscripcionErronea.Where(x => x.HistoriaClinica == nuevoTranscripcionErronea.HistoriaClinica && x.FechaOcurrencia == nuevoTranscripcionErronea.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    TranscripcionErronea transcripcionErronea = Mapper.Map<TranscripcionErronea>(nuevoTranscripcionErronea);
                    db.TranscripcionErronea.Add(transcripcionErronea);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = transcripcionErronea.IdTranscripcionErronea;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "TranscripcionErronea",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoTranscripcionErronea),
                        IdUsuario = nuevoTranscripcionErronea.IdUsuarioCreacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                }

                return respuesta;
            }
        }

        public RespuestaBD EditarSolicitudDatosIncompletos(ActualizarSolicitudDatosIncompletos actualizarSolicitudDatosIncompletos)
        {
            using (InoBD db = new InoBD())
            {
                SolicitudDatosIncompletos solicitudDatosIncompletos = db.SolicitudDatosIncompletos.Find(actualizarSolicitudDatosIncompletos.IdSolicitudDatosIncompletos);
                string valoresAntiguos = JsonConvert.SerializeObject(solicitudDatosIncompletos);
                if (solicitudDatosIncompletos != null)
                {
                    SolicitudDatosIncompletos pacienteEncontrado = db.SolicitudDatosIncompletos.Where(x => x.HistoriaClinica == actualizarSolicitudDatosIncompletos.HistoriaClinica && x.FechaOcurrencia == actualizarSolicitudDatosIncompletos.FechaOcurrencia && x.IdSolicitudDatosIncompletos != actualizarSolicitudDatosIncompletos.IdSolicitudDatosIncompletos).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(solicitudDatosIncompletos).CurrentValues.SetValues(actualizarSolicitudDatosIncompletos);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = solicitudDatosIncompletos.IdSolicitudDatosIncompletos;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "SolicitudDatosIncompletos",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarSolicitudDatosIncompletos),
                            IdUsuario = actualizarSolicitudDatosIncompletos.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El campo solicitado no existe.";
                }

                return respuesta;
            }
        }

        public RespuestaBD EditarTranscripcionErronea(ActualizarTranscripcionErronea actualizarTranscripcionErronea)
        {
            using (InoBD db = new InoBD())
            {
                TranscripcionErronea transcripcionErronea = db.TranscripcionErronea.Find(actualizarTranscripcionErronea.IdTranscripcionErronea);
                string valoresAntiguos = JsonConvert.SerializeObject(transcripcionErronea);
                if (transcripcionErronea != null)
                {
                    TranscripcionErronea pacienteEncontrado = db.TranscripcionErronea.Where(x => x.HistoriaClinica == actualizarTranscripcionErronea.HistoriaClinica && x.FechaOcurrencia == actualizarTranscripcionErronea.FechaOcurrencia && x.IdTranscripcionErronea != actualizarTranscripcionErronea.IdTranscripcionErronea).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(transcripcionErronea).CurrentValues.SetValues(actualizarTranscripcionErronea);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = transcripcionErronea.IdTranscripcionErronea;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "TranscripcionErronea",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarTranscripcionErronea),
                            IdUsuario = actualizarTranscripcionErronea.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El campo solicitado no existe.";
                }

                return respuesta;
            }
        }

        public List<SolicitudDatosIncompletosGeneral> ListarSolicitudDatosIncompletos(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.SolicitudDatosIncompletos.Where(x => Id == null || x.IdSolicitudDatosIncompletos == Id)
                                                   .ToList()
                                                   .Select(x => Mapper.Map<SolicitudDatosIncompletosGeneral>(x))
                                                   .ToList();
            }
        }

        public List<TranscripcionErroneaGeneral> ListarTranscripcionErronea(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.TranscripcionErronea.Where(x => Id == null || x.IdTranscripcionErronea == Id)
                                              .ToList()
                                              .Select(x => Mapper.Map<TranscripcionErroneaGeneral>(x))
                                              .ToList();
            }
        }
    }
}
