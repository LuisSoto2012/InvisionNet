namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoEmpleoReactivo
    {
        public int IdAreaLaboratorio { get; set; }
        public int TotalDeReactivos { get; set; }
        public int NumeroMes { get; set; }
        public int Vencidos { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
