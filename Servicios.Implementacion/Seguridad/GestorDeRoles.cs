using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Seguridad.Rol;
using Servicios.Interfaces.Seguridad.Rol.Peticiones;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using System.Collections.Generic;
using System.Linq;

namespace Servicios.Implementacion.Seguridad
{
    public class GestorDeRoles : IGestorDeRoles
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD Actualizar(ActualizarRol peticionDeActualizacion)
        {
            using (InoBD db = new InoBD())
            {
                Rol rolEncontrado = db.Roles.Find(peticionDeActualizacion.IdRol);
                string valoresAntiguos = JsonConvert.SerializeObject(rolEncontrado);
                if (rolEncontrado != null)
                {
                    db.Entry(rolEncontrado).CurrentValues.SetValues(peticionDeActualizacion);
                    db.SaveChanges();
                    respuesta.Id = rolEncontrado.IdRol;
                    //Mensaje de respuesta
                    respuesta.Mensaje = "Se modificó el rol correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "Rol",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(peticionDeActualizacion),
                        IdUsuario = peticionDeActualizacion.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El rol que desea modificar no existe.";
                }

                return respuesta;
            }
        }

        public RespuestaBD Crear(NuevoRol peticionDeCreacion)
        {
            using (InoBD db = new InoBD())
            {
                Rol rol = Mapper.Map<Rol>(peticionDeCreacion);
                Rol rolEncontrado = db.Roles.Where(x => x.Nombre == peticionDeCreacion.Nombre).FirstOrDefault();
                if (rolEncontrado == null)
                {
                    db.Roles.Add(rol);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = rol.IdRol;
                    respuesta.Mensaje = "Se creó el rol correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "Rol",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(peticionDeCreacion),
                        IdUsuario = peticionDeCreacion.IdUsuarioCreacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El rol que desea crear ya existe.";
                }

                return respuesta;
            }
        }

        public List<RolGeneral> Listar(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.Roles.Where(x => Id == null || x.IdRol == Id)
                               .ToList()
                               .Select(x => Mapper.Map<RolGeneral>(x))
                               .ToList();
            }
        }
    }
}
