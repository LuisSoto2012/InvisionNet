using System;

namespace Servicios.Interfaces.Atencion.Peticiones
{
    public class AtencionesPor
    {
        public DateTime Fecha { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdServicio { get; set; }
        public int IdMedico { get; set; }
    }
}
