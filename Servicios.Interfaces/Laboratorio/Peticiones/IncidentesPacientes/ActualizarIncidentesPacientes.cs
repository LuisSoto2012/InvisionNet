using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class ActualizarIncidentesPacientes
    {
        public int IdIncidentesPacientes { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Incidentes { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
