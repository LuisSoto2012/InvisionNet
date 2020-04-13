using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Implementacion.Paciente;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Paciente;
using Servicios.Interfaces.Paciente.Respuesta;
using Servicios.Interfaces.Ticket;
using Servicios.Interfaces.Ticket.Peticiones;

namespace Servicios.Implementacion.Ticket
{
    public class GestorDeTickets : IGestorDeTickets
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();
        IGestorDePacientes _gestorDePacientes = new GestorDePacientes();

        public RespuestaBD AgregarTicketConsultaExterna(NuevoTicketConsultaExterna nuevoTicketConsultaExterna)
        {
            using (GalenPlusBD dbGalenPlus = new GalenPlusBD())
            using (InoBD dbIno = new InoBD())
            {
                PacienteCitado pacienteCitado = this._gestorDePacientes.ListarPacienteCitadoDelDia(new PacientePorHcDni
                {
                    NroHistoriaClinica = null,
                    NroDocumento = nuevoTicketConsultaExterna.NumeroDocumento,
                    IdEspecialidad = nuevoTicketConsultaExterna.IdEspecialidad
                });

                if (pacienteCitado != null)
                {
                    TicketConsultaExterna pacienteEncontrado = dbIno.TicketConsultaExterna.Where(x => x.FechaCreacion.Day == DateTime.Now.Day &&
                                                                        x.FechaCreacion.Month == DateTime.Now.Month &&
                                                                        x.FechaCreacion.Year == DateTime.Now.Year &&
                                                                        x.HistoriaClinica == nuevoTicketConsultaExterna.HistoriaClinica &&
                                                                        x.IdEspecialidad == nuevoTicketConsultaExterna.IdEspecialidad).FirstOrDefault();
                    nuevoTicketConsultaExterna.Medico = (nuevoTicketConsultaExterna.Medico == "<SELECCIONAR>") ? " " : nuevoTicketConsultaExterna.Medico ?? " ";
                    if (pacienteEncontrado == null)
                    {
                        int pacienteTotalHoy = dbIno.TicketConsultaExterna.Where(x => x.FechaCreacion.Day == DateTime.Now.Day &&
                                                                            x.FechaCreacion.Month == DateTime.Now.Month &&
                                                                            x.FechaCreacion.Year == DateTime.Now.Year &&
                                                                            x.IdTurno == nuevoTicketConsultaExterna.IdTurno).Count();
                        TicketConsultaExterna ticketConsultaExterna = Mapper.Map<TicketConsultaExterna>(nuevoTicketConsultaExterna);
                        if (pacienteTotalHoy == 0)
                        {
                            ticketConsultaExterna.Contador = 1;
                        }
                        else
                        {
                            ticketConsultaExterna.Contador = pacienteTotalHoy + 1;
                        }
                        //Edad
                        int edad = dbGalenPlus.Database.SqlQuery<int>("dbo.Invision_ObtenerEdadPaciente @IdPaciente",
                        new SqlParameter("IdPaciente", ticketConsultaExterna.IdPaciente)).FirstOrDefault();
                        ticketConsultaExterna.Edad = edad;

                        //Nro Boleta o Fua
                        string nroBoletaFua = dbGalenPlus.Database.SqlQuery<string>("dbo.Invision_ObtenerNroBoletaFua @Fecha,@IdEspecialidad,@IdPaciente",
                        new SqlParameter("Fecha", ticketConsultaExterna.FechaCreacion),
                        new SqlParameter("IdEspecialidad", ticketConsultaExterna.IdEspecialidad),
                        new SqlParameter("IdPaciente", ticketConsultaExterna.IdPaciente)).FirstOrDefault();

                        if (nroBoletaFua != null)
                        {
                            ticketConsultaExterna.NroBoletaFua = nroBoletaFua;

                            dbIno.TicketConsultaExterna.Add(ticketConsultaExterna);
                            dbIno.SaveChanges();

                            //Mensaje de respuesta
                            respuesta.Id = ticketConsultaExterna.IdTicketConsultaExterna;
                            respuesta.Mensaje = "Se ingresó los datos correctamente.";

                            // Auditoria
                            AuditoriaGeneral auditoria = new AuditoriaGeneral
                            {
                                Accion = "Agregar",
                                NombreTabla = "TicketConsultaExterna",
                                ValoresAntiguos = null,
                                ValoresNuevos = JsonConvert.SerializeObject(nuevoTicketConsultaExterna),
                                IdUsuario = nuevoTicketConsultaExterna.IdUsuarioCreacion
                            };
                            this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                        }
                        else
                        {
                            //Mensaje de respuesta
                            respuesta.Id = 0;
                            respuesta.Mensaje = "El paciente no cuenta con número de boleta o número de FUA.";
                        }
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya ha sido ingresado con los mismos datos.";
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El paciente no se encuentra citado.";
                }

                return respuesta;
            }
        }

        public RespuestaBD ActualizarTicketIdImpresion(ActualizarTicketConsultaExterna actualizarTicketConsultaExterna)
        {
            using (InoBD db = new InoBD())
            {
                TicketConsultaExterna ticket = db.TicketConsultaExterna.Find(actualizarTicketConsultaExterna.IdTicketConsultaExterna);

                if (ticket != null)
                {
                    ticket.IdImpresion = actualizarTicketConsultaExterna.IdImpresion;
                    db.SaveChanges();
                    respuesta.Id = ticket.IdTicketConsultaExterna;
                    respuesta.Mensaje = "Se modificó el ticket correctamente.";
                }
                else
                {
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El ticket no existe.";
                }
            }

            return respuesta;
        }

        public RespuestaBD ActualizarTicketIdImpresionRevision(ActualizarTicketConsultaExterna actualizarTicketConsultaExterna)
        {
            using (InoBD db = new InoBD())
            {
                TicketConsultaExterna ticket = db.TicketConsultaExterna.Find(actualizarTicketConsultaExterna.IdTicketConsultaExterna);

                if (ticket != null)
                {
                    ticket.IdImpresionRevision = actualizarTicketConsultaExterna.IdImpresionRevision;
                    db.SaveChanges();
                    respuesta.Id = ticket.IdTicketConsultaExterna;
                    respuesta.Mensaje = "Se modificó el ticket correctamente.";
                }
                else
                {
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El ticket no existe.";
                }
            }

            return respuesta;
        }

        public List<TicketConsultaExternaGeneral> ListarTicketConsultaExterna(int? Id, DateTime? Fecha)
        {
            using (InoBD db = new InoBD())
            {
                return db.TicketConsultaExterna.Where(x => (Id == null || x.IdTicketConsultaExterna == Id) &&
                                                      (Fecha == null || (x.FechaCreacion.Day == Fecha.Value.Day && x.FechaCreacion.Month == Fecha.Value.Month && x.FechaCreacion.Year == Fecha.Value.Year) ))
                                               .ToList()
                                               .OrderByDescending(x => x.FechaCreacion)
                                               .Select(x => Mapper.Map<TicketConsultaExternaGeneral>(x))
                                               .ToList();
            }
        }

        public RespuestaBD ActualizarNroHistoriaClinicaTemporal(ActualizarHistoriaClinicaTemporal actualizarHistoriaClinicaTemporal)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                int HistoricaClinica = db.Database.SqlQuery<int>("dbo.INO_ActualizarNroHistoriaClinicaTemporal @AntiguoHC,@Hc,@IdUsuario,@IdTipoNumeracion,@IdPaciente,@IdManual",
                        new SqlParameter("AntiguoHC", actualizarHistoriaClinicaTemporal.AntiguaHistoriaClinica),
                        new SqlParameter("Hc", actualizarHistoriaClinicaTemporal.HistoriaClinica),
                        new SqlParameter("IdUsuario", actualizarHistoriaClinicaTemporal.IdUsuario),
                        new SqlParameter("IdTipoNumeracion", actualizarHistoriaClinicaTemporal.IdTipoNumeracion),
                        new SqlParameter("IdPaciente", actualizarHistoriaClinicaTemporal.IdPaciente),
                        new SqlParameter("IdManual", actualizarHistoriaClinicaTemporal.IdManual)).FirstOrDefault();

                //Mensaje de respuesta
                respuesta.Id = HistoricaClinica;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Actualizar",
                    NombreTabla = "PacientesTemporal",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(actualizarHistoriaClinicaTemporal),
                    IdUsuario = actualizarHistoriaClinicaTemporal.IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }
    }
}
