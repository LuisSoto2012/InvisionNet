namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class TranscripcionErroneaGeneral
    {
        public int IdTranscripcionErronea { get; set; }
        public string FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool NoCobrado { get; set; }
        public bool Erroneo { get; set; }
        public bool SinMovimiento { get; set; }
        public bool MovimientoIncorrecto { get; set; }
        public bool EsActivo { get; set; }
    }
}
