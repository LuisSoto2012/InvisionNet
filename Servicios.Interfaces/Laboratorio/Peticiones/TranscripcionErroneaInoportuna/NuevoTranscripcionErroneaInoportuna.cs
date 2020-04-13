using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoTranscripcionErroneaInoportuna
    {
        public DateTime FechaOcurrencia { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool CuadernoOrden { get; set; }
        public bool OrdenSistema { get; set; }
        public bool EquipoCuaderno { get; set; }
        public bool Inoportuna { get; set; }
        public string Comentario { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
