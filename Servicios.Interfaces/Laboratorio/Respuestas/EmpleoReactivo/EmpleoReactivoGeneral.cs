﻿namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class EmpleoReactivoGeneral
    {
        public int IdAreaLaboratorio { get; set; }
        public int IdEmpleoReactivo { get; set; }
        public int TotalDeReactivos { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public int Vencidos { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
