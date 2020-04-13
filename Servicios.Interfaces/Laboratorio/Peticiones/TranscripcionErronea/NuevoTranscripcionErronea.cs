using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoTranscripcionErronea
    {
        public DateTime FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool NoCobrado { get; set; }
        public bool Erroneo { get; set; }
        public bool SinMovimiento { get; set; }
        public bool MovimientoIncorrecto { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
