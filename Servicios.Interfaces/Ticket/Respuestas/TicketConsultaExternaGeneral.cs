namespace Servicios.Interfaces.Ticket
{
    public class TicketConsultaExternaGeneral
    {
        public int IdTicketConsultaExterna { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string FechaHora { get; set; }
        public string NroBoletaFua { get; set; }
        public int IdImpresion { get; set; }
        public int IdMedico { get; set; }
        public string Medico { get; set; }
        public int IdImpresionRevision { get; set; }
        public int IdTurno { get; set; }
        public int IdEspecialidad { get; set; }
        public int Prioridad { get; set; }
        public int Contador { get; set; }
        public int Edad { get; set; }
        public bool AtencionEspecial { get; set; }
        public bool EsActivo { get; set; }
    }
}
