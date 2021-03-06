﻿using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoSolicitudDatosIncompletos
    {
        public DateTime FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool FaltaDatos { get; set; }
        public bool SinMovimiento { get; set; }
        public bool MovimientoIncorrecto { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
