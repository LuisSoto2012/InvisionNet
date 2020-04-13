namespace Servicios.Interfaces.Ticket
{
    public class NuevoTicketConsultaExterna
    {
        public int IdPaciente { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public int IdImpresion { get; set; }
        public int IdMedico { get; set; }
        public string Medico { get; set; }
        public int IdImpresionRevision { get; set; }
        public int IdTurno { get; set; }
        public int IdEspecialidad { get; set; }
        public int Prioridad { get; set; }
        public bool AtencionEspecial { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
