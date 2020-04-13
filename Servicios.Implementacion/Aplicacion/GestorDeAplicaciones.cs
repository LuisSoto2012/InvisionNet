using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Aplicacion;
using Servicios.Interfaces.Aplicacion.Peticiones;
using Servicios.Interfaces.Aplicacion.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;

namespace Servicios.Implementacion.Aplicacion
{
    public class GestorDeAplicaciones : IGestorDeAplicaciones
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD Actualizar(ActualizarAplicacion peticionDeActualizacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Aplicacion aplicacionEncontrada = db.Aplicaciones.Find(peticionDeActualizacion.IdAplicacion);
                string valoresAntiguos = JsonConvert.SerializeObject(aplicacionEncontrada);
                if (aplicacionEncontrada != null)
                {
                    Dominio.Entidades.Aplicacion nombreEncontrado = db.Aplicaciones.Where(x => x.Nombre == peticionDeActualizacion.Nombre && x.IdAplicacion != peticionDeActualizacion.IdAplicacion).FirstOrDefault();
                    if (nombreEncontrado != null)
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El nombre de la aplicación ya existe.";
                    }
                    else
                    {
                        db.Entry(aplicacionEncontrada).CurrentValues.SetValues(peticionDeActualizacion);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = aplicacionEncontrada.IdAplicacion;
                        respuesta.Mensaje = "Se modificó la aplicación correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "Aplicacion",
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
                    respuesta.Mensaje = "La aplicación no existe.";
                }

                return respuesta;
            }
        }

        public RespuestaBD Crear(NuevaAplicacion peticionDeCreacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Aplicacion aplicacion = Mapper.Map<Dominio.Entidades.Aplicacion>(peticionDeCreacion);
                Dominio.Entidades.Aplicacion aplicacionEncontrada = db.Aplicaciones.Where(x => x.Nombre == peticionDeCreacion.Nombre).FirstOrDefault();
                if(aplicacionEncontrada == null)
                {
                    db.Aplicaciones.Add(aplicacion);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = aplicacion.IdAplicacion;
                    respuesta.Mensaje = "Se creó la aplicación correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "Aplicacion",
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
                    respuesta.Mensaje = "El nombre de la aplicación ya existe.";
                }

                return respuesta;
            }
        }

        public List<AplicacionGeneral> Listar(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.Aplicaciones.Where(x => Id == null || x.IdAplicacion == Id)
                                      .ToList()
                                      .Select(x => Mapper.Map<AplicacionGeneral>(x))
                                      .ToList();
            }
        }
    }
}
