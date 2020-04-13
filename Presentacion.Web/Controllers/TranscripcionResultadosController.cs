using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class TranscripcionResultadosController : ApiController
    {
        IGestorDeTranscripcionResultados _gestorDeTranscripcionResultados;

        public TranscripcionResultadosController(IGestorDeTranscripcionResultados gestorDeTranscripcionResultados)
        {
            this._gestorDeTranscripcionResultados = gestorDeTranscripcionResultados;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarPacienteSinResultado(NuevoPacienteSinResultado nuevoPacienteSinResultado)
        {
            return _gestorDeTranscripcionResultados.AgregarPacienteSinResultado(nuevoPacienteSinResultado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarTranscripcionErroneaInoportuna(NuevoTranscripcionErroneaInoportuna nuevoTranscripcionErroneaInoportuna)
        {
            return _gestorDeTranscripcionResultados.AgregarTranscripcionErroneaInoportuna(nuevoTranscripcionErroneaInoportuna);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarTranscripcionErroneaInoportuna(ActualizarTranscripcionErroneaInoportuna actualizarTranscripcionErroneaInoportuna)
        {
            return _gestorDeTranscripcionResultados.EditarTranscripcionErroneaInoportuna(actualizarTranscripcionErroneaInoportuna);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarPacienteSinResultado(ActualizarPacienteSinResultado actualizarPacienteSinResultado)
        {
            return _gestorDeTranscripcionResultados.EditarPacienteSinResultado(actualizarPacienteSinResultado);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<PacienteSinResultadoGeneral> ListarPacienteSinResultado(int? Id)
        {
            return _gestorDeTranscripcionResultados.ListarPacienteSinResultado(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<TranscripcionErroneaInoportunaGeneral> ListarTranscripcionErroneaInoportuna(int? Id)
        {
            return _gestorDeTranscripcionResultados.ListarTranscripcionErroneaInoportuna(Id);
        }
    }
}
