using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Medico.Respuestas;
using Servicios.Interfaces.Servicios;
using Servicios.Interfaces.Servicios.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class ServiciosController : ApiController
    {
        IGestorDeServicios _gestorDeServicios;

        public ServiciosController(IGestorDeServicios gestorDeServicios)
        {
            this._gestorDeServicios = gestorDeServicios;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<ServicioPorEspecialidad> ListarServicioPorEspecialidad(MedicoPorEspecialidad especialidad)
        {
            return _gestorDeServicios.ListarServicioPorEspecialidad(especialidad);
        }

    }
}
