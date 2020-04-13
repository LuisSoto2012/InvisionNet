using System;

namespace Servicios.Interfaces.Aplicacion.Peticiones
{
    public class ActualizarAplicacion
    {
        public int IdAplicacion { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public ActualizarAplicacion()
        {
            this.FechaModificacion = DateTime.Now;
        }
    }
}
