using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.OrdenMedica;
using Servicios.Interfaces.OrdenMedica.Peticiones;
using Servicios.Interfaces.OrdenMedica.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class OrdenMedicaController : ApiController
    {
        IGestorDeOrdenesMedicas _gestorDeOrdenesMedicas;

        public OrdenMedicaController(IGestorDeOrdenesMedicas gestorDeOrdenesMedicas)
        {
            this._gestorDeOrdenesMedicas = gestorDeOrdenesMedicas;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarOrdenMedica(NuevaOrdenMedica nuevaOrdenMedica)
        {
            return _gestorDeOrdenesMedicas.AgregarOrdenMedica(nuevaOrdenMedica);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<OrdenMedicaGeneral> ListarOrdenesMedicas(int? IdUsuario, int? IdOrdenMedica)
        {
            return _gestorDeOrdenesMedicas.ListarOrdenesMedicas(IdUsuario, IdOrdenMedica);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<TipoOrdenMedicaGeneral> ListarTipoOrdenMedica(int? Id)
        {
            return this._gestorDeOrdenesMedicas.ListarTipoOrdenMedica(Id);
        }
    }
}
