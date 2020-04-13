using System;

namespace Servicios.Interfaces.Paciente.Respuesta
{
    public class HistorialLaboratorio
    {
        public int IdMovimiento { get; set; }
        public int? NroHistoriaClinica { get; set; }
        public string Paciente { get; set; }
        public int IdLabEstado { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Medico { get; set; }
    }
}
