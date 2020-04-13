namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class IncidentesPacientesGeneral
    {
        public int IdIncidentesPacientes { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Incidentes { get; set; }
        public string FechaOcurrencia { get; set; }
        public bool EsActivo { get; set; }
    }
}
