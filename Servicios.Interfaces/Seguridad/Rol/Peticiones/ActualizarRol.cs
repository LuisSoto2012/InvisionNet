using System;

namespace Servicios.Interfaces.Seguridad.Rol.Peticiones
{
    public class ActualizarRol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool EsActivo { get; set; }

        public ActualizarRol()
        {
            this.FechaModificacion = DateTime.Now;
        }
    }
}
