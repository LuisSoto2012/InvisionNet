using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Presentacion.Web.Models;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Seguridad.Usuario.Peticiones;
using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;
using System.Web.Http;

namespace Presentacion.Web.Controllers.Api
{
    public class SeguridadController : ApiController
    {
        IGestorDeUsuarios _gestorDeUsuarios;
        IGestorDeToken _gestorDeToken;

        public SeguridadController(IGestorDeUsuarios gestorDeUsuarios, IGestorDeToken gestorDeToken)
        {
            this._gestorDeUsuarios = gestorDeUsuarios;
            this._gestorDeToken = gestorDeToken;
        }

        [HttpPost]
        public RespuestaDeLogin Login(UsuarioLoginModel usuarioLogin)
        {
            RespuestaDeLogin respuestaDeLogin = new RespuestaDeLogin();

            string usuario = usuarioLogin.NombreUsuario;
            string contrasena = Security.HashSHA1(usuarioLogin.Contrasena);
            UsuarioLogin respuestaLogin = this._gestorDeUsuarios.Login(usuario, contrasena, usuarioLogin.IdAplicacion);

            if (respuestaLogin == null)
            {
                respuestaDeLogin.FueExitosa = false;
                respuestaDeLogin.Mensaje = "Las credenciales son incorrectas.";
            }
            else
            {
                if (respuestaLogin.IdEmpleado == 0)
                {
                    respuestaDeLogin.FueExitosa = false;
                    respuestaDeLogin.Mensaje = "Usted no tiene permisos para ingresar a esta aplicación.";
                }
                else
                {
                    if (!respuestaLogin.LoginEstado)
                    {
                        UsuarioLogin usuarioConModulos = _gestorDeUsuarios.ObtenerMenu(respuestaLogin);
                        respuestaDeLogin.FueExitosa = true;
                        respuestaDeLogin.Token = this._gestorDeToken.GenerarToken(respuestaLogin);
                    }
                    else
                    {
                        respuestaDeLogin.FueExitosa = false;
                        respuestaDeLogin.Mensaje = "El usuario ya se encuentra logueado en otra máquina.";
                    }
                    
                }
            }
            return respuestaDeLogin;
        }

        [HttpPost]
        public RespuestaDeLogin LoginPaciente(UsuarioPaciente usuarioPaciente)
        {
            RespuestaDeLogin respuestaDeLogin = new RespuestaDeLogin();

            UsuarioLogin respuestaLogin = this._gestorDeUsuarios.LoginPaciente(usuarioPaciente);

            if (respuestaLogin == null)
            {
                respuestaDeLogin.FueExitosa = false;
                respuestaDeLogin.Mensaje = "Verifique su número de documento y correo electrónico.";
            }
            else
            {
                if (respuestaLogin.IdEmpleado == 0)
                {
                    respuestaDeLogin.FueExitosa = false;
                    respuestaDeLogin.Mensaje = "Usted no tiene permisos para ingresar a esta aplicación.";
                }
                else
                {
                    if (!respuestaLogin.LoginEstado)
                    {
                        UsuarioLogin usuarioConModulos = _gestorDeUsuarios.ObtenerMenu(respuestaLogin);
                        respuestaDeLogin.FueExitosa = true;
                        respuestaDeLogin.Token = this._gestorDeToken.GenerarToken(respuestaLogin);
                    }
                    else
                    {
                        respuestaDeLogin.FueExitosa = false;
                        respuestaDeLogin.Mensaje = "El usuario ya se encuentra logueado en otra máquina.";
                    }
                    
                }
            }
            return respuestaDeLogin;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public UsuarioLogin CorroborarCredenciales()
        {
            return ActionContext.CargarUsuario();
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD CambioClave(UsuarioCambioClave usuarioCambioClave)
        {
            return _gestorDeUsuarios.CambioClave(usuarioCambioClave);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public void UsuarioLogueado(int IdUsuario, string IpAddress)
        {
            this._gestorDeUsuarios.UsuarioLogueado(IdUsuario, IpAddress);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public void UsuarioCerrarSesion(int IdUsuario)
        {
            this._gestorDeUsuarios.UsuarioCerrarSesion(IdUsuario);
        }
    }
}
