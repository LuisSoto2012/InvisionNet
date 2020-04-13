using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarPacienteSinResultado
    {
        public int IdPacienteSinResultado { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool MuestraNoTomada { get; set; }
        public bool ResultadoNoIngresado { get; set; }
        public bool PruebaNoRegistrada { get; set; }
        public bool EsActivo { get; set; }
        public bool ResultadoNoRegistrado { get; set; }
        public bool ResultadoNoImpreso { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
