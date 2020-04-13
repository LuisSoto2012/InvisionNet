namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoMuestraHemolizadaLipemica
    {
        public int IdAreaLaboratorio { get; set; }
        public string TipoPrueba { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public int NumeroMes { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
