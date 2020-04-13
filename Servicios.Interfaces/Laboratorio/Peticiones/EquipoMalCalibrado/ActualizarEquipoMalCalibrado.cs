using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarEquipoMalCalibrado
    {
        public int IdEquipoMalCalibrado { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int TotalDeEquipos { get; set; }
        public int NumeroMes { get; set; }
        public int Inadecuados { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
