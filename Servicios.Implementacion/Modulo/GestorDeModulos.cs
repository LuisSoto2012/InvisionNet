using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Modulo;
using Servicios.Interfaces.Modulo.Peticiones;
using Servicios.Interfaces.Modulo.Respuestas;
using System.Collections.Generic;
using System.Linq;

namespace Servicios.Implementacion.Modulo
{
    public class GestorDeModulos : IGestorDeModulos
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD Actualizar(ActualizarModulo peticionDeActualizacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Modulo moduloEncontrada = db.Modulo.Find(peticionDeActualizacion.IdModulo);
                string valoresAntiguos = JsonConvert.SerializeObject(moduloEncontrada);
                if (moduloEncontrada != null)
                {
                    Dominio.Entidades.Modulo nombreEncontrado = db.Modulo.Where(x => x.Nombre == peticionDeActualizacion.Nombre && x.IdModulo != peticionDeActualizacion.IdModulo).FirstOrDefault();
                    if (nombreEncontrado != null)
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "El nombre del módulo ya existe.";
                    }
                    else
                    {
                        db.Entry(moduloEncontrada).CurrentValues.SetValues(peticionDeActualizacion);
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = moduloEncontrada.IdModulo;
                        respuesta.Mensaje = "Se modificó el módulo correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Actualizar",
                            NombreTabla = "Modulo",
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
                    respuesta.Mensaje = "El módulo no existe.";
                }

                return respuesta;
            }
        }

        public RespuestaBD Crear(NuevoModulo peticionDeCreacion)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Modulo modulo = Mapper.Map<Dominio.Entidades.Modulo>(peticionDeCreacion);
                Dominio.Entidades.Modulo moduloEncontrado = db.Modulo.Where(x => x.Nombre == peticionDeCreacion.Nombre).FirstOrDefault();
                if (moduloEncontrado == null)
                {
                    db.Modulo.Add(modulo);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = modulo.IdModulo;
                    respuesta.Mensaje = "Se creó el módulo correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "Modulo",
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
                    respuesta.Mensaje = "El nombre del módulo ya existe.";
                }

                return respuesta;
            }
        }

        public List<ModuloGeneral> Listar(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.Modulo.Where(x => Id == null || x.IdModulo == Id)
                                .OrderBy(x => x.Orden)
                                .ToList()
                                .Select(x => Mapper.Map<ModuloGeneral>(x))
                                .ToList();
            }
        }
    }
}
