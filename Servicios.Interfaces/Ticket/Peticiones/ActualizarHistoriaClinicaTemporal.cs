namespace Servicios.Interfaces.Ticket.Peticiones
{
    public class ActualizarHistoriaClinicaTemporal
    {
        public int AntiguaHistoriaClinica { get; set; }
        public int HistoriaClinica { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoNumeracion { get; set; }
        public int IdPaciente { get; set; }
        public int IdManual { get; set; }
    }
}
