using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Adicional.Peticiones
{
    public class NuevaAdicional
    {
        public string Hc { get; set; }
        public string Paciente { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdServicio { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaAdicional { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
    }
}
