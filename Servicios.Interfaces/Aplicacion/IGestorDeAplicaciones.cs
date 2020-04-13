using Servicios.Interfaces.Aplicacion.Peticiones;
using Servicios.Interfaces.Aplicacion.Respuestas;
using Servicios.Interfaces.Compartido;

namespace Servicios.Interfaces.Aplicacion
{
    public interface IGestorDeAplicaciones : IMantenimientoBasico<NuevaAplicacion, ActualizarAplicacion, AplicacionGeneral>
    {
    }
}
