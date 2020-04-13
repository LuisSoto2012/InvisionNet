using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.SubModulo;
using Servicios.Interfaces.SubModulo.Peticiones;
using Servicios.Interfaces.SubModulo.Respuestas;

namespace Servicios.Implementacion.SubModulo
{
    public class GestorDeSubModulos : IGestorDeSubModulos
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD Actualizar(ActualizarSubModulo peticionDeActualizacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.SubModulo subModuloEncontrada = db.SubModulo.Find(peticionDeActualizacion.IdSubModulo);
                string valoresAntiguos = JsonConvert.SerializeObject(subModuloEncontrada);
                if (subModuloEncontrada != null)
                {
                    Dominio.Entidades.SubModulo nombreEncontrado = db.SubModulo.Where(x => x.Nombre == peticionDeActualizacion.Nombre && x.IdModulo != peticionDeActualizacion.IdModulo).FirstOrDefault();
                    if (nombreEncontrado != null)
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El nombre del sub módulo ya existe.";
                    }
                    else
                    {
                        db.Entry(subModuloEncontrada).CurrentValues.SetValues(peticionDeActualizacion);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = subModuloEncontrada.IdSubModulo;
                        respuesta.Mensaje = "Se modificó el sub módulo correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "SubModulo",
                            ValoresAntiguos = valoresAntiguos,
                            ValoresNuevos = JsonConvert.SerializeObject(peticionDeActualizacion),
                            IdUsuario = peticionDeActualizacion.IdUsuarioModificacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El sub módulo no existe.";
                }

                return respuesta;
            }
        }

        public RespuestaBD AsignarRolSubModulo(RolSubModuloDto rolSubModuloDto)
        {
            using (InoBD db = new InoBD())
            {
                //EDITAR
                string valoresAntiguos = "";
                if(rolSubModuloDto.IdRolSubModulo > 0)
                {
                    Dominio.Entidades.RolSubModulo rolSubModulo = db.RolSubModulo.Find(rolSubModuloDto.IdRolSubModulo);
                    valoresAntiguos = JsonConvert.SerializeObject(rolSubModulo);
                    rolSubModulo.IdUsuarioModificacion = rolSubModuloDto.IdUsuarioRegistra;
                    rolSubModulo.FechaModificacion = DateTime.Now;
                    db.Entry(rolSubModulo).CurrentValues.SetValues(rolSubModuloDto);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = rolSubModulo.IdRolSubModulo;
                    respuesta.Mensaje = "Se asignó el sub módulo al rol correctamente.";
                }
                //AGREGAR
                else
                {
                    Dominio.Entidades.RolSubModulo rolSubModulo = Mapper.Map<Dominio.Entidades.RolSubModulo>(rolSubModuloDto);
                    rolSubModulo.IdUsuarioCreacion = rolSubModuloDto.IdUsuarioRegistra;
                    db.RolSubModulo.Add(rolSubModulo);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = rolSubModulo.IdRolSubModulo;
                    respuesta.Mensaje = "Se asignó el sub módulo al rol correctamente.";
                }

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "AsignarRol",
                    NombreTabla = "SubModulo",
                    ValoresAntiguos = valoresAntiguos,
                    ValoresNuevos = JsonConvert.SerializeObject(rolSubModuloDto),
                    IdUsuario = rolSubModuloDto.IdUsuarioRegistra
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD Crear(NuevoSubModulo peticionDeCreacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.SubModulo subModulo = Mapper.Map<Dominio.Entidades.SubModulo>(peticionDeCreacion);
                Dominio.Entidades.SubModulo moduloEncontrado = db.SubModulo.Where(x => x.Nombre == peticionDeCreacion.Nombre).FirstOrDefault();
                if (moduloEncontrado == null)
                {
                    db.SubModulo.Add(subModulo);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = subModulo.IdSubModulo;
                    respuesta.Mensaje = "Se creó el sub módulo correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "SubModulo",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(peticionDeCreacion),
                        IdUsuario = peticionDeCreacion.IdUsuarioCreacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El nombre del sub módulo ya existe.";
                }

                return respuesta;
            }
        }

        public List<SubModuloGeneral> Listar(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.SubModulo.Where(x => Id == null || x.IdSubModulo == Id)
                                      .OrderBy(x => x.Orden)
                                      .ToList()
                                      .Select(x => Mapper.Map<SubModuloGeneral>(x))
                                      .ToList();
            }
        }

        public List<RolSubModuloDto> ObtenerRolSubModulo(RolSubModuloDto rolSubModuloDto)
        {
            using (InoBD db = new InoBD())
            {
                return  db.RolSubModulo.Where(x =>
                                         (rolSubModuloDto.IdRol == 0 || x.IdRol == rolSubModuloDto.IdRol) &&
                                         (rolSubModuloDto.IdSubModulo == 0 || x.IdSubModulo == rolSubModuloDto.IdSubModulo))
                                    .ToList()
                                    .Select(x => Mapper.Map<RolSubModuloDto>(x))
                                    .ToList();
            }
        }
    }
}
