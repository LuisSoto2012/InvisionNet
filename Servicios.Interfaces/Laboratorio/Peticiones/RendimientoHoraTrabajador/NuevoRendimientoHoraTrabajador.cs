namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoRendimientoHoraTrabajador
    {
        public int NumeroMes { get; set; }
        public int Horas { get; set; }
        public int ExamenesProcesados { get; set; }
        public int NumeroTrabajadores { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
