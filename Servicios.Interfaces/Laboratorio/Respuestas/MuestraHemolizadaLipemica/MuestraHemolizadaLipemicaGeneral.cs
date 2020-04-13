namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class MuestraHemolizadaLipemicaGeneral
    {
        public int IdMuestraHemolizadaLipemica { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public string TipoPrueba { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
