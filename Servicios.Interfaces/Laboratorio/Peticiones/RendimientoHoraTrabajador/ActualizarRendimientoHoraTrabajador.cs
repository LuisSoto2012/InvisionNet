using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarRendimientoHoraTrabajador
    {
        public int IdRendimientoHoraTrabajador { get; set; }
        public int NumeroMes { get; set; }
        public int Horas { get; set; }
        public int ExamenesProcesados { get; set; }
        public int NumeroTrabajadores { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
