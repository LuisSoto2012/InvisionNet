namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoPocoFrecuente
    {
        public int IdAreaLaboratorio { get; set; }
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
        public int NumeroMes { get; set; }
        public int Total { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
