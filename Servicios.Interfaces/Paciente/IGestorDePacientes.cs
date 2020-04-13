using Servicios.Interfaces.Paciente.Peticiones;
using Servicios.Interfaces.Paciente.Respuesta;
using System.Collections.Generic;

namespace Servicios.Interfaces.Paciente
{
    public interface IGestorDePacientes
    {
        PacienteAfiliacion ListarPacientePorHcDni(PacientePorHcDni pacientePorHcDni);
        List<PacientePorHcDni> ListarPacientesCitadosPorEspecialidadMedicoFecha(BuscarPaciente buscarPaciente);
        List<HistorialAtenciones> ListarHistorialAtenciones(PacientePorHcDni paciente);
        List<HistorialLaboratorio> ListarHistorialLaboratorio(PacientePorHcDni paciente);
        List<HistorialRiesgoQuirurgico> ListarHistorialRiesgoQuirurgico(PacientePorHcDni paciente);
        List<HistorialCentroQuirurgico> ListarHistorialCentroQuirurgico(PacientePorHcDni paciente);
        List<HistorialEmergencia> ListarHistorialEmergencia(PacientePorHcDni paciente);
        PacienteCitado ListarPacienteCitadoDelDia(PacientePorHcDni pacientePorHcDni);
    }
}
