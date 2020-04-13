using Servicios.Interfaces.Adicional.Peticiones;
using Servicios.Interfaces.Adicional.Respuestas;
using Servicios.Interfaces.Paciente.Peticiones;
using System.Collections.Generic;

namespace Servicios.Interfaces.Adicional
{
    public interface IGestorDeAdicionales
    {
        List<Adicionales> ConsultaExternaAdicionalesPorMedicoListar(BuscarPaciente paciente);
        int ConsultaExternaAdicionalesPorMedicoRegistrar(NuevaAdicional nuevaAdicional);
    }
}
