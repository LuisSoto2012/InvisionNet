using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class PedidosAnalisisController : ApiController
    {
        IGestorDePedidosAnalisis _gestorDePedidosAnalisis;

        public PedidosAnalisisController(IGestorDePedidosAnalisis gestorDePedidosAnalisis)
        {
            this._gestorDePedidosAnalisis = gestorDePedidosAnalisis;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarSolicitudDatosIncompletos(NuevoSolicitudDatosIncompletos nuevoSolicitudDatosIncompletos)
        {
            return _gestorDePedidosAnalisis.AgregarSolicitudDatosIncompletos(nuevoSolicitudDatosIncompletos);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarTranscripcionErronea(NuevoTranscripcionErronea nuevoTranscripcionErronea)
        {
            return _gestorDePedidosAnalisis.AgregarTranscripcionErronea(nuevoTranscripcionErronea);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarSolicitudDatosIncompletos(ActualizarSolicitudDatosIncompletos actualizarSolicitudDatosIncompletos)
        {
            return _gestorDePedidosAnalisis.EditarSolicitudDatosIncompletos(actualizarSolicitudDatosIncompletos);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarTranscripcionErronea(ActualizarTranscripcionErronea actualizarTranscripcionErronea)
        {
            return _gestorDePedidosAnalisis.EditarTranscripcionErronea(actualizarTranscripcionErronea);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<SolicitudDatosIncompletosGeneral> ListarSolicitudDatosIncompletos(int? Id)
        {
            return _gestorDePedidosAnalisis.ListarSolicitudDatosIncompletos(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<TranscripcionErroneaGeneral> ListarTranscripcionErronea(int? Id)
        {
            return _gestorDePedidosAnalisis.ListarTranscripcionErronea(Id);
        }
    }
}
