using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoVenopunturasFallidas
    {
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool PacientesAdultosMayoresONinos { get; set; }
        public bool VenasDificiles { get; set; }
        public bool PacienteConPatologiaSubyacente { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public string Comentario { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
