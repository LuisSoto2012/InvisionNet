using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Reporte;
using Servicios.Interfaces.Reporte.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class ReporteController : ApiController
    {
        IGestorDeReportes _gestorDeReportes;

        public ReporteController(IGestorDeReportes gestorDeReportes)
        {
            this._gestorDeReportes = gestorDeReportes;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ReporteGeneral> Listar(int? Id)
        {
            return _gestorDeReportes.ListarReportes(Id);
        }
    }
}
