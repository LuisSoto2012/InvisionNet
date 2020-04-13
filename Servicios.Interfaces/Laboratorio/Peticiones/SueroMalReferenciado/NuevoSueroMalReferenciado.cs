namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoSueroMalReferenciado
    {
        public int IdAreaLaboratorio { get; set; }
        public bool TieneReferencia { get; set; }
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }

}
