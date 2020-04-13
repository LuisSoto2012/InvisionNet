using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;
using System.Collections.Generic;
using Dominio.Contexto;
using System.Linq;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using System;
using Servicios.Interfaces.Seguridad.Usuario.Peticiones;
using Servicios.Interfaces.SubModulo.Respuestas;
using Servicios.Interfaces.Modulo.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Implementacion.Auditoria;
using Newtonsoft.Json;
using Servicios.Interfaces.Auditoria.Peticiones;
using System.Configuration;
using Servicios.Interfaces.Paciente;
using Servicios.Implementacion.Paciente;
using Servicios.Interfaces.Paciente.Respuesta;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;

namespace Servicios.Implementacion.Seguridad
{
    public class GestorDeUsuarios : IGestorDeUsuarios
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();
        IGestorDePacientes _gestorDePacientes = new GestorDePacientes();

        public RespuestaBD Actualizar(ActualizarEmpleado peticionDeActualizacion)
        {
            using (InoBD db = new InoBD())
            {
                string valoresAntiguos = "";
                if (peticionDeActualizacion.Roles.Count > 0)
                {
                    if (peticionDeActualizacion.Aplicaciones.Count > 0)
                    {
                        Empleado usuarioEncontrado = db.Empleados.Find(peticionDeActualizacion.IdEmpleado);
                        Empleado correoEncontrado = db.Empleados.Where(x => x.Correo == peticionDeActualizacion.Correo && x.IdEmpleado != peticionDeActualizacion.IdEmpleado).FirstOrDefault();
                        Empleado documentoEncontrado = db.Empleados.Where(x => x.NumeroDocumento == peticionDeActualizacion.NumeroDocumento && x.IdEmpleado != peticionDeActualizacion.IdEmpleado).FirstOrDefault();
                        Empleado codigoPlanillaEncontrado = db.Empleados.Where(x => x.CodigoPlanilla == peticionDeActualizacion.CodigoPlanilla && x.IdEmpleado != peticionDeActualizacion.IdEmpleado).FirstOrDefault();
                        valoresAntiguos = JsonConvert.SerializeObject(usuarioEncontrado);
                        if (usuarioEncontrado != null)
                        {
                            if (correoEncontrado != null)
                            {
                                //Mensaje de respuesta
                                respuesta.Id = 0;
                                respuesta.Mensaje = "El correo del usuario ya existe.";
                            }
                            else if (documentoEncontrado != null)
                            {
                                //Mensaje de respuesta
                                respuesta.Id = 0;
                                respuesta.Mensaje = "El número de documento del usuario ya existe.";
                            }
                            else if (codigoPlanillaEncontrado != null)
                            {
                                //Mensaje de respuesta
                                respuesta.Id = 0;
                                respuesta.Mensaje = "El código de planilla del usuario ya existe.";
                            }
                            else
                            {
                                usuarioEncontrado.IdCondicionTrabajo = peticionDeActualizacion.CondicionTrabajo.Id;
                                usuarioEncontrado.IdTipoEmpleado = peticionDeActualizacion.TipoEmpleado.Id;
                                usuarioEncontrado.IdTipoDocumento = peticionDeActualizacion.TipoDocumentoIdentidad.Id;
                                LimpiarObjeto(usuarioEncontrado);
                                db.Entry(usuarioEncontrado).CurrentValues.SetValues(peticionDeActualizacion);
                                List<int> idRoles = peticionDeActualizacion.Roles.Select(r => r.IdRol).ToList();
                                List<Rol> roles = db.Roles.Where(r => idRoles.Contains(r.IdRol)).ToList();
                                foreach (Rol rol in roles)
                                {
                                    usuarioEncontrado.Roles.Add(rol);
                                }
                                List<int> idAplicaciones = peticionDeActualizacion.Aplicaciones.Select(r => r.IdAplicacion).ToList();
                                List<Dominio.Entidades.Aplicacion> aplicaciones = db.Aplicaciones.Where(a => idAplicaciones.Contains(a.IdAplicacion)).ToList();
                                foreach (Dominio.Entidades.Aplicacion aplicacion in aplicaciones)
                                {
                                    usuarioEncontrado.Aplicaciones.Add(aplicacion);
                                }
                                db.SaveChanges();
                                //Mensaje de respuesta
                                respuesta.Id = usuarioEncontrado.IdEmpleado;
                                respuesta.Mensaje = "Se modificó el empleado correctamente.";

                                // Auditoria
                                AuditoriaGeneral auditoria = new AuditoriaGeneral
                                {
                                    Accion = "Actualizar",
                                    NombreTabla = "Empleado",
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
                            respuesta.Mensaje = "El usuario no existe.";
                        }
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "No se ha seleccionado ninguna aplicación, verifique.";
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "No se ha seleccionado ningún rol, verifique.";
                }

                return respuesta;
            }
        }

        public RespuestaBD CambioClave(UsuarioCambioClave usuarioCambioClave)
        {
            using (InoBD db = new InoBD())
            {
                usuarioCambioClave.ClaveAntigua = Security.HashSHA1(usuarioCambioClave.ClaveAntigua);
                Empleado empleado = db.Empleados.Where(x => x.Usuario == usuarioCambioClave.Usuario && x.Contrasena == usuarioCambioClave.ClaveAntigua).FirstOrDefault();
                int UsuarioAdmin = Convert.ToInt32(ConfigurationManager.AppSettings["UsuarioAdmin"]);
                if (empleado != null && usuarioCambioClave.IdUsuarioModificacion == UsuarioAdmin)
                {
                    empleado = db.Empleados.Where(x => x.Usuario == usuarioCambioClave.Usuario).FirstOrDefault();
                }
                if (empleado != null)
                {
                    if (usuarioCambioClave.ClaveNueva == usuarioCambioClave.ClaveNuevaRepetida)
                    {
                        empleado.Contrasena = Security.HashSHA1(usuarioCambioClave.ClaveNueva);
                        empleado.IdUsuarioModificacion = usuarioCambioClave.IdUsuarioModificacion;
                        empleado.FechaModificacion = DateTime.Now;
                        db.SaveChanges();
                        //Mensaje de respuesta
                        respuesta.Id = empleado.IdEmpleado;
                        respuesta.Mensaje = "La contraseña se cambió correctamente.";

                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "CambioDeClave",
                            NombreTabla = "Empleado",
                            ValoresAntiguos = null,
                            ValoresNuevos = JsonConvert.SerializeObject(usuarioCambioClave),
                            IdUsuario = usuarioCambioClave.IdUsuarioModificacion
                        };

                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "Las contraseñas nuevas son diferentes, intente nuevamente.";
                    }
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "La contraseña ingresada no es correcta, intente nuevamente.";
                }

                return respuesta;
            } 
        }

        public RespuestaBD Crear(NuevoEmpleado peticionDeCreacion)
        {
            using (InoBD db = new InoBD())
            {
                //var idRoles = Array.ConvertAll(peticionDeCreacion.IdRoles.Split(','), int.Parse);
                //List<Rol> roles = db.Roles.Where(x => x.EsActivo == true && idRoles.Contains(x.IdRol)).ToList();
                Empleado empleado = Mapper.Map<Empleado>(peticionDeCreacion);
                if (peticionDeCreacion.Roles.Count > 0)
                {
                    if (peticionDeCreacion.Aplicaciones.Count > 0)
                    {
                        Empleado usuarioEncontrado = db.Empleados.Where(x => x.Usuario == peticionDeCreacion.Usuario).FirstOrDefault();
                        Empleado correoEncontrado = db.Empleados.Where(x => x.Correo == peticionDeCreacion.Correo).FirstOrDefault();
                        Empleado documentoEncontrado = db.Empleados.Where(x => x.NumeroDocumento == peticionDeCreacion.NumeroDocumento).FirstOrDefault();
                        Empleado codigoPlanillaEncontrado = db.Empleados.Where(x => x.CodigoPlanilla == peticionDeCreacion.CodigoPlanilla).FirstOrDefault();
                        if (usuarioEncontrado != null)
                        {
                            //Mensaje de respuesta
                            respuesta.Id = 0;
                            respuesta.Mensaje = "El nombre de usuario ya existe.";
                        }
                        else if (correoEncontrado != null)
                        {
                            //Mensaje de respuesta
                            respuesta.Id = 0;
                            respuesta.Mensaje = "El correo del usuario ya existe.";
                        }
                        else if (documentoEncontrado != null)
                        {
                            //Mensaje de respuesta
                            respuesta.Id = 0;
                            respuesta.Mensaje = "El número de documento del usuario ya existe.";
                        }
                        else if (codigoPlanillaEncontrado != null)
                        {
                            //Mensaje de respuesta
                            respuesta.Id = 0;
                            respuesta.Mensaje = "El código de planilla del usuario ya existe.";
                        }
                        else
                        {
                            empleado.Contrasena = Security.HashSHA1(peticionDeCreacion.Contrasena);
                            LimpiarObjeto(empleado);
                            db.Empleados.Add(empleado);
                            List<int> idRoles = peticionDeCreacion.Roles.Select(r => r.IdRol).ToList();
                            List<Rol> roles = db.Roles.Where(r => idRoles.Contains(r.IdRol)).ToList();
                            foreach (Rol rol in roles)
                            {
                                empleado.Roles.Add(rol);
                            }
                            List<int> idAplicaciones = peticionDeCreacion.Aplicaciones.Select(r => r.IdAplicacion).ToList();
                            List<Dominio.Entidades.Aplicacion> aplicaciones = db.Aplicaciones.Where(a => idAplicaciones.Contains(a.IdAplicacion)).ToList();
                            foreach (Dominio.Entidades.Aplicacion aplicacion in aplicaciones)
                            {
                                empleado.Aplicaciones.Add(aplicacion);
                            }
                            db.SaveChanges();
                            //Mensaje de respuesta
                            respuesta.Id = empleado.IdEmpleado;
                            respuesta.Mensaje = "Se creó el empleado correctamente.";

                            // Auditoria
                            AuditoriaGeneral auditoria = new AuditoriaGeneral
                            {
                                Accion = "Agregar",
                                NombreTabla = "Empleado",
                                ValoresAntiguos = null,
                                ValoresNuevos = JsonConvert.SerializeObject(peticionDeCreacion),
                                IdUsuario = peticionDeCreacion.IdUsuarioCreacion
                            };
                            this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                        }
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "No se ha seleccionado ninguna aplicación, verifique.";
                    }

                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "No se ha seleccionado ningún rol, verifique.";
                }

                return respuesta;
            }
        }

        public List<EmpleadoGeneral> Listar(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.Empleados.Where(x => Id == null || x.IdEmpleado == Id)
                                   .ToList()
                                   .Select(x => Mapper.Map<EmpleadoGeneral>(x))
                                   .ToList();
            }
        }

        public UsuarioLogin Login(string username, string password, int idAplicacion)
        {
            using (InoBD db = new InoBD())
            {
                Empleado empleado = db.Empleados.Where(x => x.Usuario == username && x.Contrasena == password && x.EsActivo == true).FirstOrDefault();
                //Verificar si el usuario pertenece a la aplicacion
                Dominio.Entidades.Aplicacion aplicacion = (empleado == null) ? new Dominio.Entidades.Aplicacion() : empleado.Aplicaciones.Where(x => x.IdAplicacion == idAplicacion && x.EsActivo == true).FirstOrDefault();
                UsuarioLogin usuarioGeneral = (aplicacion == null) ? new UsuarioLogin() : Mapper.Map<UsuarioLogin>(empleado);
                return usuarioGeneral;
            }

        }

        public UsuarioLogin LoginPaciente(UsuarioPaciente usuarioPaciente)
        {
            using (InoBD db = new InoBD())
            {
                PacienteAfiliacion paciente = this._gestorDePacientes.ListarPacientePorHcDni(new PacientePorHcDni {
                    NroHistoriaClinica = null,
                    NroDocumento = usuarioPaciente.NroDocumento,
                    Temporal = false
                });

                UsuarioLogin usuarioGeneral = null;

                if (paciente != null && paciente.Correo == usuarioPaciente.Correo)
                {
                    string[] NombreCompleto = paciente.Paciente.Split(',');
                    var Roles = db.Empleados.Find(usuarioPaciente.IdEmpleado).Roles.Select(x => Mapper.Map<RolGeneral>(x)).ToList();
                    usuarioGeneral = new UsuarioLogin
                    {
                        IdEmpleado = usuarioPaciente.IdEmpleado,
                        Usuario = "",
                        Nombres = NombreCompleto[1].Trim(),
                        ApellidoPaterno = NombreCompleto[0].Split(' ')[0],
                        LoginEstado = false,
                        Roles = Roles
                    };
                }
                return usuarioGeneral;
            }

        }

        private void LimpiarObjeto(Empleado empleado)
        {
            empleado.CondicionTrabajo = null;
            empleado.TipoEmpleado = null;
            empleado.TipoDocumentoIdentidad = null;
            empleado.Aplicaciones.Clear();
            empleado.Roles.Clear();
        }

        public UsuarioLogin ObtenerMenu(UsuarioLogin usuarioLogin)
        {
            using (InoBD db = new InoBD())
            {
                List<SubModuloMenu> subModulos = (from e in db.Roles
                                                  join rsm in db.RolSubModulo on e.IdRol equals rsm.IdRol
                                                  join sm in db.SubModulo on rsm.IdSubModulo equals sm.IdSubModulo
                                                  where e.Empleado.Any(x => x.IdEmpleado == usuarioLogin.IdEmpleado)
                                                  && rsm.EsActivo == true
                                                  orderby sm.Orden ascending
                                                  select new SubModuloMenu
                                                  {
                                                      IdSubModulo = sm.IdSubModulo,
                                                      IdModulo = sm.IdModulo,
                                                      SubModulo = sm.Nombre,
                                                      Ruta = sm.Ruta,
                                                      Orden = sm.Orden,
                                                      Ver = rsm.Ver,
                                                      Agregar = rsm.Agregar,
                                                      Editar = rsm.Editar,
                                                      Eliminar = rsm.Eliminar
                                                  }).ToList();

                List<ModuloMenu> modulos = (from e in db.Roles
                                            join rsm in db.RolSubModulo on e.IdRol equals rsm.IdRol
                                            join sm in db.SubModulo on rsm.IdSubModulo equals sm.IdSubModulo
                                            join m in db.Modulo on sm.IdModulo equals m.IdModulo
                                            where e.Empleado.Any(x => x.IdEmpleado == usuarioLogin.IdEmpleado)
                                            && rsm.EsActivo == true
                                            select new ModuloMenu
                                            {
                                                IdModulo = m.IdModulo,
                                                Modulo = m.Nombre,
                                                Icono = m.Icono,
                                                Orden = m.Orden,
                                            }).Distinct().OrderBy(x => x.Orden).ToList();

                List<ModuloMenu> menuModulo = modulos
                    .Select(x => new ModuloMenu
                    {
                        IdModulo = x.IdModulo,
                        Modulo = x.Modulo,
                        Icono = x.Icono,
                        Orden = x.Orden,
                        SubModulo = subModulos.Where(y => y.IdModulo == x.IdModulo).ToList()
                    }).ToList();

                usuarioLogin.Modulo = menuModulo;
                return usuarioLogin;
            }
        }

        public void UsuarioLogueado(int idUsuario, string ipAddress)
        {
            using (InoBD db = new InoBD())
            {
                Empleado usuario = db.Empleados.Find(idUsuario);
                usuario.LoginEstado = false;
                usuario.LoginIp = ipAddress;
                db.SaveChanges();
            }
        }

        public void UsuarioCerrarSesion(int idUsuario)
        {
            using (InoBD db = new InoBD())
            {
                Empleado usuario = db.Empleados.Find(idUsuario);
                usuario.LoginEstado = false;
                usuario.LoginIp = "";
                db.SaveChanges();
            }
        }
    }
}
