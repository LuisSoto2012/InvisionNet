namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class TranscripcionErroneaInoportunaGeneral
    {
        public int IdTranscripcionErroneaInoportuna { get; set; }
        public string FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool CuadernoOrden { get; set; }
        public bool OrdenSistema { get; set; }
        public bool EquipoCuaderno { get; set; }
        public bool Inoportuna { get; set; }
        public string Comentario { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
    }
}
