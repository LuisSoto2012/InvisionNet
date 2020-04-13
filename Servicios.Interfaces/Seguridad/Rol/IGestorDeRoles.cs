using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Seguridad.Rol.Peticiones;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using Servicios.Interfaces.Usuario.Peticiones;

namespace Servicios.Interfaces.Seguridad.Rol
{
    public interface IGestorDeRoles : IMantenimientoBasico<NuevoRol, ActualizarRol, RolGeneral>
    {
        
    }
}
