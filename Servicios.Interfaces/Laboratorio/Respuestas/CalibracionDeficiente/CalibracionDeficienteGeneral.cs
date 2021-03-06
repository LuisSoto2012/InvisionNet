﻿namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class CalibracionDeficienteGeneral
    {
        public int IdCalibracionDeficiente { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public bool EstaCalibrado { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public string Observaciones { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
