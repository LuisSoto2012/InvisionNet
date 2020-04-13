using System;

namespace Servicios.Interfaces.Atencion.Peticiones
{
    public class CitasPor
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int IdMedico { get; set; }
    }
}
