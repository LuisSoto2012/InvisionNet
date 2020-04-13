using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Seguridad.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;

namespace Servicios.Interfaces.Usuario
{
    public interface IGestorDeUsuarios : IMantenimientoBasico<NuevoEmpleado, ActualizarEmpleado, EmpleadoGeneral>
    {
        UsuarioLogin Login(string username, string password, int idAplicacion);
        UsuarioLogin LoginPaciente(UsuarioPaciente usuarioPaciente);
        RespuestaBD CambioClave(UsuarioCambioClave usuarioCambioClave);
        UsuarioLogin ObtenerMenu(UsuarioLogin usuarioLogin);
        void UsuarioLogueado(int idUsuario, string ipAddress);
        void UsuarioCerrarSesion(int idUsuario);
    }
}
