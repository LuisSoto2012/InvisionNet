namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class SolicitudDatosIncompletosGeneral
    {
        public int IdSolicitudDatosIncompletos { get; set; }
        public string FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool FaltaDatos { get; set; }
        public bool SinMovimiento { get; set; }
        public bool MovimientoIncorrecto { get; set; }
        public bool EsActivo { get; set; }
    }
}
