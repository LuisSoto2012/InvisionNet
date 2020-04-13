using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoIncidentesPacientes
    {
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Incidentes { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
