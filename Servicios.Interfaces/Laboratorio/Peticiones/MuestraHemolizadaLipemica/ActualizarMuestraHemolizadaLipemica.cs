using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarMuestraHemolizadaLipemica
    {
        public int IdMuestraHemolizadaLipemica { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public string TipoPrueba { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public int NumeroMes { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
