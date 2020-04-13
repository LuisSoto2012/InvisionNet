namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class VenopunturasFallidasGeneral
    {
        public int IdVenopunturasFallidas { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool PacientesAdultosMayoresONinos { get; set; }
        public bool VenasDificiles { get; set; }
        public bool PacienteConPatologiaSubyacente { get; set; }
        public string FechaOcurrencia { get; set; }
        public string Comentario { get; set; }
        public bool EsActivo { get; set; }
    }
}
