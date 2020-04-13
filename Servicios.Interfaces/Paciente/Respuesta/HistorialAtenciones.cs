﻿using System;

namespace Servicios.Interfaces.Paciente.Respuesta
{
    public class HistorialAtenciones
    {
        public DateTime FechaAtencion { get; set; }
        public string NroHistoriaClinica { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Especialidad { get; set; }
        public string Servicio { get; set; }
        public string Diagnostico1 { get; set; }
        public string Diagnostico2 { get; set; }
        public string Diagnostico3 { get; set; }
        public string Procedimiento1 { get; set; }
        public string Procedimiento2 { get; set; }
        public string Procedimiento3 { get; set; }
        public string Diacod { get; set; }
        public string Diades { get; set; }
    }
}
