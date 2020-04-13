using Servicios.Interfaces.Usuario.Peticiones;

namespace Servicios.Interfaces.Seguridad.Token
{
    public interface IGestorDeToken
    {
        string GenerarToken(UsuarioLogin usuarioGeneral);
        UsuarioLogin RecuperarInformacionDeUsuario(string token);
    }
}
