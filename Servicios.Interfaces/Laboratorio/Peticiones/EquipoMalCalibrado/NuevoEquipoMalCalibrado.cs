﻿namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoEquipoMalCalibrado
    {
        public int IdAreaLaboratorio { get; set; }
        public int TotalDeEquipos { get; set; }
        public int NumeroMes { get; set; }
        public int Inadecuados { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
