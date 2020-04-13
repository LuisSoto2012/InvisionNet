using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Ticket.Peticiones;
using System;
using System.Collections.Generic;

namespace Servicios.Interfaces.Ticket
{
    public interface IGestorDeTickets
    {
        List<TicketConsultaExternaGeneral> ListarTicketConsultaExterna(int? Id, DateTime? Fecha);
        RespuestaBD AgregarTicketConsultaExterna(NuevoTicketConsultaExterna nuevoTicketConsultaExterna);
        RespuestaBD ActualizarTicketIdImpresion(ActualizarTicketConsultaExterna actualizarTicketConsultaExterna);
        RespuestaBD ActualizarTicketIdImpresionRevision(ActualizarTicketConsultaExterna actualizarTicketConsultaExterna);
        RespuestaBD ActualizarNroHistoriaClinicaTemporal(ActualizarHistoriaClinicaTemporal actualizarHistoriaClinicaTemporal);
    }
}
