namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoCalibracionDeficiente
    {
        public int IdAreaLaboratorio { get; set; }
        public bool EstaCalibrado { get; set; }
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
