using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Modulo.Peticiones;
using Servicios.Interfaces.Modulo.Respuestas;

namespace Servicios.Interfaces.Modulo
{
    public interface IGestorDeModulos : IMantenimientoBasico<NuevoModulo, ActualizarModulo, ModuloGeneral>
    {
    }
}
