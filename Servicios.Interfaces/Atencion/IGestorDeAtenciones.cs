using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Atencion.Peticiones;
using Servicios.Interfaces.Atencion.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Atencion
{
    public interface IGestorDeAtenciones
    {
        List<AtencionFiltro> ListarAtenciones(AtencionesPor atencionesPor);
        List<CitadosPorFecha> ListarCitadosPorFecha(CitasPor citasPor);
        List<CitadosPorFechaMedicoEspecialidad> ListarCitadosPorFechaMedicoEspecialidad(PacientesPor PacientesPor);
        RespuestaBD RegistrarAtencion(RegistroAtencion nuevaAtencion);
        RespuestaBD ActualizarAtencion(RegistroAtencion nuevaAtencion);
        List<Diagnostico> ListarDiagnosticos(Diagnostico diagnostico);
        List<ProcedimientoDto> ListarProcedimientos(ProcedimientoDto procedimiento);
    }
}
