﻿namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class PocoFrecuenteGeneral
    {
        public int IdPocoFrecuente { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
        public int NumeroMes { get; set; }
        public int Total { get; set; }
        public bool EsActivo { get; set; }
        public string AreaLaboratorio { get; set; }
        public string NombreMes { get; set; }
        public string FechaCreacion { get; set; }
    }
}
