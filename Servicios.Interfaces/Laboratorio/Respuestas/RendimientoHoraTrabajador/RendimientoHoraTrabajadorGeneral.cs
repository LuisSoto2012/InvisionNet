namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class RendimientoHoraTrabajadorGeneral
    {
        public int IdRendimientoHoraTrabajador { get; set; }
        public int NumeroMes { get; set; }
        public int Horas { get; set; }
        public int ExamenesProcesados { get; set; }
        public int NumeroTrabajadores { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public string AreaLaboratorio { get; set; }
        public string NombreMes { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
