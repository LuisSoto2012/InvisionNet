using System;

namespace Servicios.Interfaces.BonoDesempeno.Peticiones
{
    public class DatosTramaBono
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int IdEspecialidad { get; set; }
        public char Tipo_Paciente { get; set; } = 'T';
        public int[] Selected { get; set; }
    }
}
