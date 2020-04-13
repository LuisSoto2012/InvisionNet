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
    public class GestorDeTranscripcionResultados : IGestorDeTranscripcionResultados
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD AgregarPacienteSinResultado(NuevoPacienteSinResultado nuevoPacienteSinResultado)
        {
            using (InoBD db = new InoBD())
            {
                PacienteSinResultado pacienteEncontrado = db.PacienteSinResultado.Where(x => x.HistoriaClinica == nuevoPacienteSinResultado.HistoriaClinica && x.FechaOcurrencia == nuevoPacienteSinResultado.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    PacienteSinResultado pacienteSinResultado = Mapper.Map<PacienteSinResultado>(nuevoPacienteSinResultado);
                    db.PacienteSinResultado.Add(pacienteSinResultado);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = pacienteSinResultado.IdPacienteSinResultado;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "PacienteSinResultado",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoPacienteSinResultado),
                        IdUsuario = nuevoPacienteSinResultado.IdUsuarioCreacion
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

        public RespuestaBD AgregarTranscripcionErroneaInoportuna(NuevoTranscripcionErroneaInoportuna nuevoTranscripcionErroneaInoportuna)
        {
            using (InoBD db = new InoBD())
            {
                TranscripcionErroneaInoportuna pacienteEncontrado = db.TranscripcionErroneaInoportuna.Where(x => x.HistoriaClinica == nuevoTranscripcionErroneaInoportuna.HistoriaClinica && x.FechaOcurrencia == nuevoTranscripcionErroneaInoportuna.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    TranscripcionErroneaInoportuna transcripcionErroneaInoportuna = Mapper.Map<TranscripcionErroneaInoportuna>(nuevoTranscripcionErroneaInoportuna);
                    db.TranscripcionErroneaInoportuna.Add(transcripcionErroneaInoportuna);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = transcripcionErroneaInoportuna.IdTranscripcionErroneaInoportuna;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "TranscripcionErroneaInoportuna",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoTranscripcionErroneaInoportuna),
                        IdUsuario = nuevoTranscripcionErroneaInoportuna.IdUsuarioCreacion
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

        public RespuestaBD EditarTranscripcionErroneaInoportuna(ActualizarTranscripcionErroneaInoportuna actualizarTranscripcionErroneaInoportuna)
        {
            using (InoBD db = new InoBD())
            {
                TranscripcionErroneaInoportuna transcripcionErroneaInoportuna = db.TranscripcionErroneaInoportuna.Find(actualizarTranscripcionErroneaInoportuna.IdTranscripcionErroneaInoportuna);
                string valoresAntiguos = JsonConvert.SerializeObject(transcripcionErroneaInoportuna);
                if (transcripcionErroneaInoportuna != null)
                {
                    TranscripcionErroneaInoportuna pacienteEncontrado = db.TranscripcionErroneaInoportuna.Where(x => x.HistoriaClinica == actualizarTranscripcionErroneaInoportuna.HistoriaClinica && x.FechaOcurrencia == actualizarTranscripcionErroneaInoportuna.FechaOcurrencia && x.IdTranscripcionErroneaInoportuna != actualizarTranscripcionErroneaInoportuna.IdTranscripcionErroneaInoportuna).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(transcripcionErroneaInoportuna).CurrentValues.SetValues(actualizarTranscripcionErroneaInoportuna);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = transcripcionErroneaInoportuna.IdTranscripcionErroneaInoportuna;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "TranscripcionErroneaInoportuna",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarTranscripcionErroneaInoportuna),
                            IdUsuario = actualizarTranscripcionErroneaInoportuna.IdUsuarioModificacion
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

        public RespuestaBD EditarPacienteSinResultado(ActualizarPacienteSinResultado actualizarPacienteSinResultado)
        {
            using (InoBD db = new InoBD())
            {
                PacienteSinResultado pacienteSinResultado = db.PacienteSinResultado.Find(actualizarPacienteSinResultado.IdPacienteSinResultado);
                string valoresAntiguos = JsonConvert.SerializeObject(pacienteSinResultado);
                if (pacienteSinResultado != null)
                {
                    PacienteSinResultado pacienteEncontrado = db.PacienteSinResultado.Where(x => x.HistoriaClinica == actualizarPacienteSinResultado.HistoriaClinica && x.FechaOcurrencia == actualizarPacienteSinResultado.FechaOcurrencia && x.IdPacienteSinResultado != actualizarPacienteSinResultado.IdPacienteSinResultado).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(pacienteSinResultado).CurrentValues.SetValues(actualizarPacienteSinResultado);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = pacienteSinResultado.IdPacienteSinResultado;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "PacienteSinResultado",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarPacienteSinResultado),
                            IdUsuario = actualizarPacienteSinResultado.IdUsuarioModificacion
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

        public List<PacienteSinResultadoGeneral> ListarPacienteSinResultado(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.PacienteSinResultado.Where(x => Id == null || x.IdPacienteSinResultado == Id)
                                              .ToList()
                                              .Select(x => Mapper.Map<PacienteSinResultadoGeneral>(x))
                                              .ToList();
            }
        }

        public List<TranscripcionErroneaInoportunaGeneral> ListarTranscripcionErroneaInoportuna(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.TranscripcionErroneaInoportuna.Where(x => Id == null || x.IdTranscripcionErroneaInoportuna == Id)
                                                        .ToList()
                                                        .Select(x => Mapper.Map<TranscripcionErroneaInoportunaGeneral>(x))
                                                        .ToList();
            }
        }
    }
}
