using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarRecoleccionMuestra
    {
        public int IdRecoleccionMuestra { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool RecoleccionInapropiada { get; set; }
        public bool MuestrasPerdidas { get; set; }
        public bool MuestrasMalRotuladas { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public string Comentario { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
