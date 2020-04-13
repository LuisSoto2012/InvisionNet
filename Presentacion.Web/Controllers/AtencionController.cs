using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Atencion;
using Servicios.Interfaces.Atencion.Peticiones;
using Servicios.Interfaces.Atencion.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class AtencionController : ApiController
    {
        IGestorDeAtenciones _gestorDeAtenciones;

        public AtencionController(IGestorDeAtenciones gestorDeAtenciones)
        {
            this._gestorDeAtenciones = gestorDeAtenciones;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<CitadosPorFecha> ListarCitadosPorFecha(CitasPor citasPor)
        {
            return _gestorDeAtenciones.ListarCitadosPorFecha(citasPor);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<CitadosPorFechaMedicoEspecialidad> ListarCitadosPorFechaMedicoEspecialidad(PacientesPor PacientesPor)
        {
            return _gestorDeAtenciones.ListarCitadosPorFechaMedicoEspecialidad(PacientesPor);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<AtencionFiltro> ListarAtenciones(AtencionesPor atencionesPor)
        {
            return _gestorDeAtenciones.ListarAtenciones(atencionesPor);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<Diagnostico> ListarDiagnosticos(Diagnostico diagnostico)
        {
            return _gestorDeAtenciones.ListarDiagnosticos(diagnostico);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<ProcedimientoDto> ListarProcedimientos(ProcedimientoDto procedimiento)
        {
            return _gestorDeAtenciones.ListarProcedimientos(procedimiento);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD RegistrarAtencion(RegistroAtencion nuevaAtencion)
        {
            return _gestorDeAtenciones.RegistrarAtencion(nuevaAtencion);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD ActualizarAtencion(RegistroAtencion nuevaAtencion)
        {
            return _gestorDeAtenciones.ActualizarAtencion(nuevaAtencion);
        }
    }
}
