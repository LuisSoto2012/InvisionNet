using System;

namespace Servicios.Interfaces.Archivo.Peticiones
{
    public class ConsultarArchivoPor
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int IdUsuario { get; set; }
    }
}
