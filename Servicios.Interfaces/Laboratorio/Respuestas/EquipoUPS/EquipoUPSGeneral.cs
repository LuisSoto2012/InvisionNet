﻿namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class EquipoUPSGeneral
    {
        public int IdEquipoUPS { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool TieneUPS { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public string Observaciones { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}