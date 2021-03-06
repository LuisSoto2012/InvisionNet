﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Adicional.Respuestas
{
    public class Adicionales
    {
        public int IdAdicional { get; set; }
        public string Hc { get; set; }
        public string Paciente { get; set; }
        public string Especialidad { get; set; }
        public string Medico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAdicional { get; set; }
    }
}
