using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Comunes;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class ComunesController : ApiController
    {
        IGestorDeComunes _gestorDeComunes;

        public ComunesController(IGestorDeComunes gestorDeComunes)
        {
            this._gestorDeComunes = gestorDeComunes;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarCondicionTrabajo()
        {
            return _gestorDeComunes.ListarCondicionTrabajo();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarTipoDocumentoIdentidad()
        {
            return _gestorDeComunes.ListarTipoDocumentoIdentidad();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarTipoEmpleado()
        {
            return _gestorDeComunes.ListarTipoEmpleado();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarAreaLaboratorio(int? Id)
        {
            return _gestorDeComunes.ListarAreaLaboratorio(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarPruebaLabotario(string Codigo)
        {
            return _gestorDeComunes.ListarPruebaLabotario(Codigo);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarServicioEspecialidad(int? Id)
        {
            return _gestorDeComunes.ListarServicioEspecialidad(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarEspecialidades()
        {
            return _gestorDeComunes.ListarEspecialidades();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarUsuarioPorRol(int IdRol)
        {
            return this._gestorDeComunes.ListarUsuarioPorRol(IdRol);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarAlmacenes()
        {
            return this._gestorDeComunes.ListarAlmacenes();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ComboBox> ListarEscalafonDeLegajos()
        {
            return this._gestorDeComunes.ListarEscalafonDeLegajos();
        }

        [HttpGet]
        //[RequiereAutenticacion]
        public List<ComboBox> ListarCajeros()
        {
            return this._gestorDeComunes.ListarCajeros();
        }
    }
}
