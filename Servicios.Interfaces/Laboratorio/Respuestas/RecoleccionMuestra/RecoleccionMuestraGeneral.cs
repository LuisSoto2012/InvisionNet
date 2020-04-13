namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class RecoleccionMuestraGeneral
    {
        public int IdRecoleccionMuestra { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool RecoleccionInapropiada { get; set; }
        public bool MuestrasPerdidas { get; set; }
        public bool MuestrasMalRotuladas { get; set; }
        public string FechaOcurrencia { get; set; }
        public string Comentario { get; set; }
        public bool EsActivo { get; set; }
    }
}
