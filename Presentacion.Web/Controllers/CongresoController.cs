using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Congreso;
using Servicios.Interfaces.Congreso.Peticiones;
using Servicios.Interfaces.Congreso.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class CongresoController : ApiController
    {
        IGestorDeCongreso _gestorDeCongreso;

        public CongresoController(IGestorDeCongreso gestorDeCongreso)
        {
            this._gestorDeCongreso = gestorDeCongreso;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<AsistenciaGeneral> EventoAsistenciaListar(int IdHorario, int IdEvento)
        {
            return _gestorDeCongreso.EventoAsistenciaListar(IdHorario, IdEvento);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EventoAsistenciaRegistrar(NuevaAsistencia nuevaAsistencia)
        {
            return _gestorDeCongreso.EventoAsistenciaRegistrar(nuevaAsistencia);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<EventoGeneral> EventoListar()
        {
            return _gestorDeCongreso.EventoListar();
        }

        [HttpGet]
        [RequiereAutenticacion]
        public ParticipanteGeneral EventoParticipanteXDNI(string NumeroDocumento)
        {
            return _gestorDeCongreso.EventoParticipanteXDNI(NumeroDocumento);
        }
    }
}
