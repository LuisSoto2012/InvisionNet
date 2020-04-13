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
    public class GestorDeProcesoAnalitico : IGestorDeProcesoAnalitico
    {
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();
        RespuestaBD respuesta = new RespuestaBD();


        public RespuestaBD AgregarCalibracionDeficiente(NuevoCalibracionDeficiente nuevoCalibracionDeficiente)
        {
            using (InoBD db = new InoBD())
            {
                CalibracionDeficiente calibracionDeficiente = Mapper.Map<CalibracionDeficiente>(nuevoCalibracionDeficiente);
                db.CalibracionDeficiente.Add(calibracionDeficiente);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = calibracionDeficiente.IdCalibracionDeficiente;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "CalibracionDeficiente",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoCalibracionDeficiente),
                    IdUsuario = nuevoCalibracionDeficiente.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }

        }

        public RespuestaBD AgregarEmpleoReactivo(NuevoEmpleoReactivo nuevoEmpleoReactivo)
        {
            using (InoBD db = new InoBD())
            {
                EmpleoReactivo empleoReactivo = Mapper.Map<EmpleoReactivo>(nuevoEmpleoReactivo);
                db.EmpleoReactivo.Add(empleoReactivo);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = empleoReactivo.IdEmpleoReactivo;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "EmpleoReactivo",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoEmpleoReactivo),
                    IdUsuario = nuevoEmpleoReactivo.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD AgregarEquipoMalCalibrado(NuevoEquipoMalCalibrado nuevoEquipoMalCalibrado)
        {
            using (InoBD db = new InoBD())
            {
                EquipoMalCalibrado equipoMalCalibrado = Mapper.Map<EquipoMalCalibrado>(nuevoEquipoMalCalibrado);
                db.EquipoMalCalibrado.Add(equipoMalCalibrado);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = equipoMalCalibrado.IdEquipoMalCalibrado;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "EquipoMalCalibrado",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoEquipoMalCalibrado),
                    IdUsuario = nuevoEquipoMalCalibrado.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD AgregarEquipoUPS(NuevoEquipoUPS nuevoEquipoUPS)
        {
            using (InoBD db = new InoBD())
            {
                EquipoUPS equipoUPS = Mapper.Map<EquipoUPS>(nuevoEquipoUPS);
                db.EquipoUPS.Add(equipoUPS);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = equipoUPS.IdEquipoUPS;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "EquipoUPS",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoEquipoUPS),
                    IdUsuario = nuevoEquipoUPS.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD AgregarMaterialNoCalibrado(NuevoMaterialNoCalibrado nuevoMaterialNoCalibrado)
        {
            using (InoBD db = new InoBD())
            {
                MaterialNoCalibrado materialNoCalibrado = Mapper.Map<MaterialNoCalibrado>(nuevoMaterialNoCalibrado);
                db.MaterialNoCalibrado.Add(materialNoCalibrado);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = materialNoCalibrado.IdMaterialNoCalibrado;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "MaterialNoCalibrado",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoMaterialNoCalibrado),
                    IdUsuario = nuevoMaterialNoCalibrado.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD AgregarMuestraHemolizadaLipemica(NuevoMuestraHemolizadaLipemica nuevoMuestraHemolizadaLipemica)
        {
            using (InoBD db = new InoBD())
            {
                MuestraHemolizadaLipemica pacienteEncontrado = db.MuestraHemolizadaLipemica.Where(x => x.HistoriaClinica == nuevoMuestraHemolizadaLipemica.HistoriaClinica && x.NumeroMes == nuevoMuestraHemolizadaLipemica.NumeroMes).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    MuestraHemolizadaLipemica muestraHemolizadaLipemica = Mapper.Map<MuestraHemolizadaLipemica>(nuevoMuestraHemolizadaLipemica);
                    db.MuestraHemolizadaLipemica.Add(muestraHemolizadaLipemica);
                    db.SaveChanges();

                    //Mensaje de respuesta
                    respuesta.Id = muestraHemolizadaLipemica.IdMuestraHemolizadaLipemica;
                    respuesta.Mensaje = "Se ingresó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "MuestraHemolizadaLipemica",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevoMuestraHemolizadaLipemica),
                        IdUsuario = nuevoMuestraHemolizadaLipemica.IdUsuarioCreacion
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

        public RespuestaBD AgregarPocoFrecuente(NuevoPocoFrecuente nuevoPocoFrecuente)
        {
            using (InoBD db = new InoBD())
            {
                PocoFrecuente pocoFrecuente = Mapper.Map<PocoFrecuente>(nuevoPocoFrecuente);
                db.PocoFrecuente.Add(pocoFrecuente);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = pocoFrecuente.IdPocoFrecuente;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "PocoFrecuente",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoPocoFrecuente),
                    IdUsuario = nuevoPocoFrecuente.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD AgregarSueroMalReferenciado(NuevoSueroMalReferenciado nuevoSueroMalReferenciado)
        {
            using (InoBD db = new InoBD())
            {
                SueroMalReferenciado sueroMalReferenciado = Mapper.Map<SueroMalReferenciado>(nuevoSueroMalReferenciado);
                db.SueroMalReferenciado.Add(sueroMalReferenciado);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = sueroMalReferenciado.IdSueroMalReferenciado;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "SueroMalReferenciado",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoSueroMalReferenciado),
                    IdUsuario = nuevoSueroMalReferenciado.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD EditarCalibracionDeficiente(ActualizarCalibracionDeficiente actualizarCalibracionDeficiente)
        {
            using (InoBD db = new InoBD())
            {
                CalibracionDeficiente calibracionDeficiente = db.CalibracionDeficiente.Find(actualizarCalibracionDeficiente.IdCalibracionDeficiente);
                string valoresAntiguos = JsonConvert.SerializeObject(calibracionDeficiente);
                if (calibracionDeficiente != null)
                {
                    db.Entry(calibracionDeficiente).CurrentValues.SetValues(actualizarCalibracionDeficiente);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = calibracionDeficiente.IdCalibracionDeficiente;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "CalibracionDeficiente",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarCalibracionDeficiente),
                        IdUsuario = actualizarCalibracionDeficiente.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarEmpleoReactivo(ActualizarEmpleoReactivo actualizarEmpleoReactivo)
        {
            using (InoBD db = new InoBD())
            {
                EmpleoReactivo empleoReactivo = db.EmpleoReactivo.Find(actualizarEmpleoReactivo.IdEmpleoReactivo);
                string valoresAntiguos = JsonConvert.SerializeObject(empleoReactivo);
                if (empleoReactivo != null)
                {
                    db.Entry(empleoReactivo).CurrentValues.SetValues(actualizarEmpleoReactivo);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = empleoReactivo.IdEmpleoReactivo;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "EmpleoReactivo",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarEmpleoReactivo),
                        IdUsuario = actualizarEmpleoReactivo.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarEquipoMalCalibrado(ActualizarEquipoMalCalibrado actualizarEquipoMalCalibrado)
        {
            using (InoBD db = new InoBD())
            {
                EquipoMalCalibrado equipoMalCalibrado = db.EquipoMalCalibrado.Find(actualizarEquipoMalCalibrado.IdEquipoMalCalibrado);
                string valoresAntiguos = JsonConvert.SerializeObject(equipoMalCalibrado);
                if (equipoMalCalibrado != null)
                {
                    db.Entry(equipoMalCalibrado).CurrentValues.SetValues(actualizarEquipoMalCalibrado);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = equipoMalCalibrado.IdEquipoMalCalibrado;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "EquipoMalCalibrado",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarEquipoMalCalibrado),
                        IdUsuario = actualizarEquipoMalCalibrado.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarEquipoUPS(ActualizarEquipoUPS actualizarEquipoUPS)
        {
            using (InoBD db = new InoBD())
            {
                EquipoUPS equipoUPS = db.EquipoUPS.Find(actualizarEquipoUPS.IdEquipoUPS);
                string valoresAntiguos = JsonConvert.SerializeObject(equipoUPS);
                if (equipoUPS != null)
                {
                    db.Entry(equipoUPS).CurrentValues.SetValues(actualizarEquipoUPS);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = equipoUPS.IdEquipoUPS;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "EquipoUPS",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarEquipoUPS),
                        IdUsuario = actualizarEquipoUPS.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarMaterialNoCalibrado(ActualizarMaterialNoCalibrado actualizarMaterialNoCalibrado)
        {
            using (InoBD db = new InoBD())
            {
                MaterialNoCalibrado materialNoCalibrado = db.MaterialNoCalibrado.Find(actualizarMaterialNoCalibrado.IdMaterialNoCalibrado);
                string valoresAntiguos = JsonConvert.SerializeObject(materialNoCalibrado);
                if (materialNoCalibrado != null)
                {
                    db.Entry(materialNoCalibrado).CurrentValues.SetValues(actualizarMaterialNoCalibrado);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = materialNoCalibrado.IdMaterialNoCalibrado;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "MaterialNoCalibrado",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarMaterialNoCalibrado),
                        IdUsuario = actualizarMaterialNoCalibrado.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarMuestraHemolizadaLipemica(ActualizarMuestraHemolizadaLipemica actualizarMuestraHemolizadaLipemica)
        {
            using (InoBD db = new InoBD())
            {
                MuestraHemolizadaLipemica muestraHemolizadaLipemica = db.MuestraHemolizadaLipemica.Find(actualizarMuestraHemolizadaLipemica.IdMuestraHemolizadaLipemica);
                string valoresAntiguos = JsonConvert.SerializeObject(muestraHemolizadaLipemica);
                if (muestraHemolizadaLipemica != null)
                {
                    MuestraHemolizadaLipemica pacienteEncontrado = db.MuestraHemolizadaLipemica.Where(x => x.HistoriaClinica == actualizarMuestraHemolizadaLipemica.HistoriaClinica && x.NumeroMes == actualizarMuestraHemolizadaLipemica.NumeroMes && x.IdMuestraHemolizadaLipemica != actualizarMuestraHemolizadaLipemica.IdMuestraHemolizadaLipemica).FirstOrDefault();
                    if (pacienteEncontrado == null)
                    {
                        db.Entry(muestraHemolizadaLipemica).CurrentValues.SetValues(actualizarMuestraHemolizadaLipemica);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = muestraHemolizadaLipemica.IdMuestraHemolizadaLipemica;
                        respuesta.Mensaje = "Se modificó los datos correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "MuestraHemolizadaLipemica",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(actualizarMuestraHemolizadaLipemica),
                            IdUsuario = actualizarMuestraHemolizadaLipemica.IdUsuarioModificacion
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

        public RespuestaBD EditarPocoFrecuente(ActualizarPocoFrecuente actualizarPocoFrecuente)
        {
            using (InoBD db = new InoBD())
            {
                PocoFrecuente pocoFrecuente = db.PocoFrecuente.Find(actualizarPocoFrecuente.IdPocoFrecuente);
                string valoresAntiguos = JsonConvert.SerializeObject(pocoFrecuente);
                if (pocoFrecuente != null)
                {
                    db.Entry(pocoFrecuente).CurrentValues.SetValues(actualizarPocoFrecuente);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = pocoFrecuente.IdPocoFrecuente;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "PocoFrecuente",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarPocoFrecuente),
                        IdUsuario = actualizarPocoFrecuente.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public RespuestaBD EditarSueroMalReferenciado(ActualizarSueroMalReferenciado actualizarSueroMalReferenciado)
        {
            using (InoBD db = new InoBD())
            {
                SueroMalReferenciado sueroMalReferenciado = db.SueroMalReferenciado.Find(actualizarSueroMalReferenciado.IdSueroMalReferenciado);
                string valoresAntiguos = JsonConvert.SerializeObject(sueroMalReferenciado);
                if (sueroMalReferenciado != null)
                {
                    db.Entry(sueroMalReferenciado).CurrentValues.SetValues(actualizarSueroMalReferenciado);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = sueroMalReferenciado.IdSueroMalReferenciado;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "SueroMalReferenciado",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarSueroMalReferenciado),
                        IdUsuario = actualizarSueroMalReferenciado.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
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

        public List<CalibracionDeficienteGeneral> ListarCalibracionDeficiente(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.CalibracionDeficiente.Where(x => Id == null || x.IdCalibracionDeficiente == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<CalibracionDeficienteGeneral>(x))
                                      .ToList();
            }
        }

        public List<EmpleoReactivoGeneral> ListarEmpleoReactivo(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.EmpleoReactivo.Where(x => Id == null || x.IdEmpleoReactivo == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<EmpleoReactivoGeneral>(x))
                                      .ToList();
            }
        }

        public List<EquipoMalCalibradoGeneral> ListarEquipoMalCalibrado(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.EquipoMalCalibrado.Where(x => Id == null || x.IdEquipoMalCalibrado == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<EquipoMalCalibradoGeneral>(x))
                                      .ToList();
            }
        }

        public List<EquipoUPSGeneral> ListarEquipoUPS(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.EquipoUPS.Where(x => Id == null || x.IdEquipoUPS == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<EquipoUPSGeneral>(x))
                                      .ToList();
            }
        }

        public List<MaterialNoCalibradoGeneral> ListarMaterialNoCalibrado(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.MaterialNoCalibrado.Where(x => Id == null || x.IdMaterialNoCalibrado == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<MaterialNoCalibradoGeneral>(x))
                                      .ToList();
            }
        }

        public List<MuestraHemolizadaLipemicaGeneral> ListarMuestraHemolizadaLipemica(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.MuestraHemolizadaLipemica.Where(x => Id == null || x.IdMuestraHemolizadaLipemica == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<MuestraHemolizadaLipemicaGeneral>(x))
                                      .ToList();
            }
        }

        public List<PocoFrecuenteGeneral> ListarPocoFrecuente(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.PocoFrecuente.Where(x => Id == null || x.IdPocoFrecuente == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<PocoFrecuenteGeneral>(x))
                                      .ToList();
            }
        }

        public List<SueroMalReferenciadoGeneral> ListarSueroMalReferenciado(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.SueroMalReferenciado.Where(x => Id == null || x.IdSueroMalReferenciado == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<SueroMalReferenciadoGeneral>(x))
                                      .ToList();
            }
        }
    }
}
