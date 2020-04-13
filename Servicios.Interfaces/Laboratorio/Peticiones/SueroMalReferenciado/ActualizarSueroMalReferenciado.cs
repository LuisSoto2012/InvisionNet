using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarSueroMalReferenciado
    {
        public int IdSueroMalReferenciado { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool TieneReferencia { get; set; }
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
