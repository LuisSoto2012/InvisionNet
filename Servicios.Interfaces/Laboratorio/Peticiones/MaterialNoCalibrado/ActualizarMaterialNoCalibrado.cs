using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarMaterialNoCalibrado
    {
        public int IdMaterialNoCalibrado { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int NumeroMes { get; set; }
        public int Calibrado { get; set; }
        public int NoCalibrado { get; set; }
        public int Inoperativo { get; set; }
        public int Total { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
