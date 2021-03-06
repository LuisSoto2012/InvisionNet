﻿using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarPocoFrecuente
    {
        public int IdPocoFrecuente { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
        public int NumeroMes { get; set; }
        public int Total { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
