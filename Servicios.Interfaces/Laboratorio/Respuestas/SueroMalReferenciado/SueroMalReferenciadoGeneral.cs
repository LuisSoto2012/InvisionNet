﻿namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class SueroMalReferenciadoGeneral
    {
        public int IdSueroMalReferenciado { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool TieneReferencia { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public string Observaciones { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
