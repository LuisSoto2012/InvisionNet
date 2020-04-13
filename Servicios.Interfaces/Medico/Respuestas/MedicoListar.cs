using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Medico.Respuestas
{
    public class MedicoListar
    {
        public int IdMedico { get; set; }
        public int IdEmpleado { get; set; }
        public string Medico { get; set; }
    }
}
