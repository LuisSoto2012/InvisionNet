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
using System.Collections.Generic;
using System.Linq;

namespace Servicios.Implementacion.Laboratorio
{
    public class GestorDeTomaMuestra : IGestorDeTomaMuestra
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD AgregarIncidentesPacientes(NuevoIncidentesPacientes nuevoIncidentesPacientes)
        {
            using (InoBD db = new InoBD())
            {
                IncidentesPacientes pacienteEncontrado = db.IncidentesPacientes.Where(x => x.HistoriaClinica == nuevoIncidentesPacientes.HistoriaClinica && x.FechaOcurrencia == nuevoIncidentesPacientes.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    IncidentesPacientes incidentesPacientes = Mapper.Map<IncidentesPacientes>(nuevoIncidentesPacientes);
                    db.IncidentesPacientes.Add(incidentesPacientes);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = incidentesPacientes.IdIncidentesPacientes;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "IncidentesPacientes",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoIncidentesPacientes),
                        IdUsuario = nuevoIncidentesPacientes.IdUsuarioCreacion
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

        public RespuestaBD AgregarIncumplimientoAnalisis(NuevoIncumplimientoAnalisis nuevoIncumplimientoAnalisis)
        {
            using (InoBD db = new InoBD())
            {
                IncumplimientoAnalisis pacienteEncontrado = db.IncumplimientoAnalisis.Where(x => x.HistoriaClinica == nuevoIncumplimientoAnalisis.HistoriaClinica && x.FechaOcurrencia == nuevoIncumplimientoAnalisis.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    IncumplimientoAnalisis incumplimientoAnalisis = Mapper.Map<IncumplimientoAnalisis>(nuevoIncumplimientoAnalisis);
                    db.IncumplimientoAnalisis.Add(incumplimientoAnalisis);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = incumplimientoAnalisis.IdIncumplimientoAnalisis;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "IncumplimientoAnalisis",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoIncumplimientoAnalisis),
                        IdUsuario = nuevoIncumplimientoAnalisis.IdUsuarioCreacion
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

        public RespuestaBD AgregarPruebasNoRealizadas(NuevoPruebasNoRealizadas nuevoPruebasNoRealizadas)
        {
            using (InoBD db = new InoBD())
            {
                PruebasNoRealizadas pacienteEncontrado = db.PruebasNoRealizadas.Where(x => x.HistoriaClinica == nuevoPruebasNoRealizadas.HistoriaClinica && x.FechaOcurrencia == nuevoPruebasNoRealizadas.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    PruebasNoRealizadas pruebasNoRealizadas = Mapper.Map<PruebasNoRealizadas>(nuevoPruebasNoRealizadas);
                    db.PruebasNoRealizadas.Add(pruebasNoRealizadas);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = pruebasNoRealizadas.IdPruebasNoRealizadas;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "PruebasNoRealizadas",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoPruebasNoRealizadas),
                        IdUsuario = nuevoPruebasNoRealizadas.IdUsuarioCreacion
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

        public RespuestaBD AgregarRecoleccionMuestra(NuevoRecoleccionMuestra nuevoRecoleccionMuestra)
        {
            using (InoBD db = new InoBD())
            {
                RecoleccionMuestra pacienteEncontrado = db.RecoleccionMuestra.Where(x => x.HistoriaClinica == nuevoRecoleccionMuestra.HistoriaClinica && x.FechaOcurrencia == nuevoRecoleccionMuestra.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    RecoleccionMuestra recoleccionMuestra = Mapper.Map<RecoleccionMuestra>(nuevoRecoleccionMuestra);
                    db.RecoleccionMuestra.Add(recoleccionMuestra);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = recoleccionMuestra.IdRecoleccionMuestra;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "RecoleccionMuestra",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoRecoleccionMuestra),
                        IdUsuario = nuevoRecoleccionMuestra.IdUsuarioCreacion
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

        public RespuestaBD AgregarVenopunturasFallidas(NuevoVenopunturasFallidas nuevoVenopunturasFallidas)
        {
            using (InoBD db = new InoBD())
            {
                VenopunturasFallidas pacienteEncontrado = db.VenopunturasFallidas.Where(x => x.HistoriaClinica == nuevoVenopunturasFallidas.HistoriaClinica && x.FechaOcurrencia == nuevoVenopunturasFallidas.FechaOcurrencia).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    VenopunturasFallidas venopunturasFallidas = Mapper.Map<VenopunturasFallidas>(nuevoVenopunturasFallidas);
                    db.VenopunturasFallidas.Add(venopunturasFallidas);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = venopunturasFallidas.IdVenopunturasFallidas;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "VenopunturasFallidas",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoVenopunturasFallidas),
                        IdUsuario = nuevoVenopunturasFallidas.IdUsuarioCreacion
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

        public RespuestaBD EditarIncidentesPacientes(ActualizarIncidentesPacientes actualizarIncidentesPacientes)
        {
            using (InoBD db = new InoBD())
            {
                
                IncidentesPacientes incidentesPacientes = db.IncidentesPacientes.Find(actualizarIncidentesPacientes.IdIncidentesPacientes);
                string valoresAntiguos = JsonConvert.SerializeObject(incidentesPacientes);
                if (incidentesPacientes != null)
                {
                    IncidentesPacientes pacienteEncontrado = db.IncidentesPacientes.Where(x => x.HistoriaClinica == actualizarIncidentesPacientes.HistoriaClinica && x.FechaOcurrencia == actualizarIncidentesPacientes.FechaOcurrencia && x.IdIncidentesPacientes != actualizarIncidentesPacientes.IdIncidentesPacientes).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(incidentesPacientes).CurrentValues.SetValues(actualizarIncidentesPacientes);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = incidentesPacientes.IdIncidentesPacientes;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "IncidentesPacientes",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarIncidentesPacientes),
                            IdUsuario = actualizarIncidentesPacientes.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                        return respuesta;
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

        public RespuestaBD EditarIncumplimientoAnalisis(ActualizarIncumplimientoAnalisis actualizarIncumplimientoAnalisis)
        {
            using (InoBD db = new InoBD())
            {
                IncumplimientoAnalisis incumplimientoAnalisis = db.IncumplimientoAnalisis.Find(actualizarIncumplimientoAnalisis.IdIncumplimientoAnalisis);
                string valoresAntiguos = JsonConvert.SerializeObject(incumplimientoAnalisis);
                if (incumplimientoAnalisis != null)
                {
                    IncumplimientoAnalisis pacienteEncontrado = db.IncumplimientoAnalisis.Where(x => x.HistoriaClinica == actualizarIncumplimientoAnalisis.HistoriaClinica && x.FechaOcurrencia == actualizarIncumplimientoAnalisis.FechaOcurrencia && x.IdIncumplimientoAnalisis != actualizarIncumplimientoAnalisis.IdIncumplimientoAnalisis).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(incumplimientoAnalisis).CurrentValues.SetValues(actualizarIncumplimientoAnalisis);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = incumplimientoAnalisis.IdIncumplimientoAnalisis;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "IncumplimientoAnalisis",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarIncumplimientoAnalisis),
                            IdUsuario = actualizarIncumplimientoAnalisis.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                        return respuesta;
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

        public RespuestaBD EditarPruebasNoRealizadas(ActualizarPruebasNoRealizadas actualizarPruebasNoRealizadas)
        {
            using (InoBD db = new InoBD())
            {
                PruebasNoRealizadas pruebasNoRealizadas = db.PruebasNoRealizadas.Find(actualizarPruebasNoRealizadas.IdPruebasNoRealizadas);
                string valoresAntiguos = JsonConvert.SerializeObject(pruebasNoRealizadas);
                if (pruebasNoRealizadas != null)
                {
                    PruebasNoRealizadas pacienteEncontrado = db.PruebasNoRealizadas.Where(x => x.HistoriaClinica == actualizarPruebasNoRealizadas.HistoriaClinica && x.FechaOcurrencia == actualizarPruebasNoRealizadas.FechaOcurrencia && x.IdPruebasNoRealizadas != actualizarPruebasNoRealizadas.IdPruebasNoRealizadas).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(pruebasNoRealizadas).CurrentValues.SetValues(actualizarPruebasNoRealizadas);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = pruebasNoRealizadas.IdPruebasNoRealizadas;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "PruebasNoRealizadas",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarPruebasNoRealizadas),
                            IdUsuario = actualizarPruebasNoRealizadas.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                        return respuesta;
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

        public RespuestaBD EditarRecoleccionMuestra(ActualizarRecoleccionMuestra actualizarRecoleccionMuestra)
        {
            using (InoBD db = new InoBD())
            {
                RecoleccionMuestra recoleccionMuestra = db.RecoleccionMuestra.Find(actualizarRecoleccionMuestra.IdRecoleccionMuestra);
                string valoresAntiguos = JsonConvert.SerializeObject(recoleccionMuestra);
                if (recoleccionMuestra != null)
                {
                    RecoleccionMuestra pacienteEncontrado = db.RecoleccionMuestra.Where(x => x.HistoriaClinica == actualizarRecoleccionMuestra.HistoriaClinica && x.FechaOcurrencia == actualizarRecoleccionMuestra.FechaOcurrencia && x.IdRecoleccionMuestra != actualizarRecoleccionMuestra.IdRecoleccionMuestra).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(recoleccionMuestra).CurrentValues.SetValues(actualizarRecoleccionMuestra);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = recoleccionMuestra.IdRecoleccionMuestra;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "RecoleccionMuestra",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarRecoleccionMuestra),
                            IdUsuario = actualizarRecoleccionMuestra.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                        return respuesta;
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

        public RespuestaBD EditarVenopunturasFallidas(ActualizarVenopunturasFallidas actualizarVenopunturasFallidas)
        {
            using (InoBD db = new InoBD())
            {
                VenopunturasFallidas venopunturasFallidas = db.VenopunturasFallidas.Find(actualizarVenopunturasFallidas.IdVenopunturasFallidas);
                string valoresAntiguos = JsonConvert.SerializeObject(venopunturasFallidas);
                if (venopunturasFallidas != null)
                {
                    VenopunturasFallidas pacienteEncontrado = db.VenopunturasFallidas.Where(x => x.HistoriaClinica == actualizarVenopunturasFallidas.HistoriaClinica && x.FechaOcurrencia == actualizarVenopunturasFallidas.FechaOcurrencia && x.IdVenopunturasFallidas != actualizarVenopunturasFallidas.IdVenopunturasFallidas).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(venopunturasFallidas).CurrentValues.SetValues(actualizarVenopunturasFallidas);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = venopunturasFallidas.IdVenopunturasFallidas;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "VenopunturasFallidas",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarVenopunturasFallidas),
                            IdUsuario = actualizarVenopunturasFallidas.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El paciente ya se encuentra registrado para esta fecha.";
                        return respuesta;
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

        public List<IncidentesPacientesGeneral> ListarIncidentesPacientes(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.IncidentesPacientes.Where(x => Id == null || x.IdIncidentesPacientes == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<IncidentesPacientesGeneral>(x))
                                      .ToList();
            }
        }

        public List<IncumplimientoAnalisisGeneral> ListarIncumplimientoAnalisis(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.IncumplimientoAnalisis.Where(x => Id == null || x.IdIncumplimientoAnalisis == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<IncumplimientoAnalisisGeneral>(x))
                                      .ToList();
            }
        }

        public List<PruebasNoRealizadasGeneral> ListarPruebasNoRealizadas(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.PruebasNoRealizadas.Where(x => Id == null || x.IdPruebasNoRealizadas == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<PruebasNoRealizadasGeneral>(x))
                                      .ToList();
            }
        }

        public List<RecoleccionMuestraGeneral> ListarRecoleccionMuestra(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.RecoleccionMuestra.Where(x => Id == null || x.IdRecoleccionMuestra == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<RecoleccionMuestraGeneral>(x))
                                      .ToList();
            }
        }

        public List<VenopunturasFallidasGeneral> ListarVenopunturasFallidas(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.VenopunturasFallidas.Where(x => Id == null || x.IdVenopunturasFallidas == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<VenopunturasFallidasGeneral>(x))
                                      .ToList();
            }
        }
    }
}
