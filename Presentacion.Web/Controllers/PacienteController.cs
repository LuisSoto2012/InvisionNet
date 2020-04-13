using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Paciente;
using Servicios.Interfaces.Paciente.Peticiones;
using Servicios.Interfaces.Paciente.Respuesta;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class PacienteController : ApiController
    {
        IGestorDePacientes _gestorDePacientes;

        public PacienteController(IGestorDePacientes gestorDePacientes)
        {
            this._gestorDePacientes = gestorDePacientes;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<HistorialAtenciones> ListarHistorialAtenciones(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarHistorialAtenciones(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<HistorialCentroQuirurgico> ListarHistorialCentroQuirurgico(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarHistorialCentroQuirurgico(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<HistorialEmergencia> ListarHistorialEmergencia(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarHistorialEmergencia(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<HistorialLaboratorio> ListarHistorialLaboratorio(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarHistorialLaboratorio(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<HistorialRiesgoQuirurgico> ListarHistorialRiesgoQuirurgico(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarHistorialRiesgoQuirurgico(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public PacienteAfiliacion ListarPacientePorHcDni(PacientePorHcDni paciente)
        {
            return _gestorDePacientes.ListarPacientePorHcDni(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<PacientePorHcDni> ListarPacientesCitadosPorEspecialidadMedicoFecha(BuscarPaciente paciente)
        {
            return _gestorDePacientes.ListarPacientesCitadosPorEspecialidadMedicoFecha(paciente);
        }
    }
}
