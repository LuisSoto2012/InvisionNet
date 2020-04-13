using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarEmpleoReactivo
    {
        public int IdAreaLaboratorio { get; set; }
        public int IdEmpleoReactivo { get; set; }
        public int TotalDeReactivos { get; set; }
        public int NumeroMes { get; set; }
        public int Vencidos { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
