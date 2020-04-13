using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class IndicadoresGestionController : ApiController
    {
        IGestorDeIndicadoresGestion _gestorDeIndicadoresGestion;

        public IndicadoresGestionController(IGestorDeIndicadoresGestion gestorDeIndicadoresGestion)
        {
            this._gestorDeIndicadoresGestion = gestorDeIndicadoresGestion;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarRendimientoHoraTrabajador(NuevoRendimientoHoraTrabajador nuevoRendimientoHoraTrabajador)
        {
            return _gestorDeIndicadoresGestion.AgregarRendimientoHoraTrabajador(nuevoRendimientoHoraTrabajador);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarRendimientoHoraTrabajador(ActualizarRendimientoHoraTrabajador actualizarRendimientoHoraTrabajador)
        {
            return _gestorDeIndicadoresGestion.EditarRendimientoHoraTrabajador(actualizarRendimientoHoraTrabajador);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<RendimientoHoraTrabajadorGeneral> ListarRendimientoHoraTrabajador(int? Id)
        {
            return _gestorDeIndicadoresGestion.ListarRendimientoHoraTrabajador(Id);
        }
    }
}
