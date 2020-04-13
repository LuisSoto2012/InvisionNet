using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Ticket;
using Servicios.Interfaces.Ticket.Peticiones;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class TicketController : ApiController
    {
        IGestorDeTickets _gestorDeTickets;

        public TicketController(IGestorDeTickets gestorDeTickets)
        {
            this._gestorDeTickets = gestorDeTickets;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarTicketConsultaExterna(NuevoTicketConsultaExterna nuevoTicketConsultaExterna)
        {
            return _gestorDeTickets.AgregarTicketConsultaExterna(nuevoTicketConsultaExterna);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD ActualizarTicketIdImpresion(ActualizarTicketConsultaExterna actualizarTickeConsultaExterna)
        {
            return _gestorDeTickets.ActualizarTicketIdImpresion(actualizarTickeConsultaExterna);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD ActualizarTicketIdImpresionRevision(ActualizarTicketConsultaExterna actualizarTickeConsultaExterna)
        {
            return _gestorDeTickets.ActualizarTicketIdImpresionRevision(actualizarTickeConsultaExterna);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD ActualizarNroHistoriaClinicaTemporal(ActualizarHistoriaClinicaTemporal actualizarHistoriaClinicaTemporal)
        {
            return _gestorDeTickets.ActualizarNroHistoriaClinicaTemporal(actualizarHistoriaClinicaTemporal);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<TicketConsultaExternaGeneral> ListarTicketConsultaExterna(int? Id, DateTime? Fecha)
        {
            return _gestorDeTickets.ListarTicketConsultaExterna(Id, Fecha);
        }
    }
}
