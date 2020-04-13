namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class PacienteSinResultadoGeneral
    {
        public int IdPacienteSinResultado { get; set; }
        public string FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool MuestraNoTomada { get; set; }
        public bool ResultadoNoIngresado { get; set; }
        public bool PruebaNoRegistrada { get; set; }
        public bool ResultadoNoRegistrado { get; set; }
        public bool ResultadoNoImpreso { get; set; }
        public bool EsActivo { get; set; }
    }
}
