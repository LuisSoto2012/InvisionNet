using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Adicional;
using Servicios.Interfaces.Adicional.Peticiones;
using Servicios.Interfaces.Adicional.Respuestas;
using Servicios.Interfaces.Paciente.Peticiones;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class AdicionalesController : ApiController
    {
        IGestorDeAdicionales _gestorDeAdicionales;

        public AdicionalesController(IGestorDeAdicionales gestorDeAdicionales)
        {
            this._gestorDeAdicionales = gestorDeAdicionales;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<Adicionales> ConsultaExternaAdicionalesPorMedicoListar(BuscarPaciente paciente)
        {
            return _gestorDeAdicionales.ConsultaExternaAdicionalesPorMedicoListar(paciente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public int ConsultaExternaAdicionalesPorMedicoRegistrar(NuevaAdicional nuevaAdicional)
        {
            return _gestorDeAdicionales.ConsultaExternaAdicionalesPorMedicoRegistrar(nuevaAdicional);
        }
    }
}
