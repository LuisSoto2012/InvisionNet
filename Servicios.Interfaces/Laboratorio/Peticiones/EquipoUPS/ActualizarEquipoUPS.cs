using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarEquipoUPS
    {
        public int IdEquipoUPS { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool TieneUPS { get; set; }
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
