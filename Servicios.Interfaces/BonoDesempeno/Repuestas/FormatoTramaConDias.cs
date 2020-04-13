using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.BonoDesempeno.Repuestas
{
    public class FormatoTramaConDias
    {
        public int id_referencia { get; set; }
        public int id_cita { get; set; }
        public int tipo { get; set; }
        public int dias { get; set; }
        public object ipress { get; set; }
        public object paciente { get; set; }
        public object registro { get; set; }
    }
}
