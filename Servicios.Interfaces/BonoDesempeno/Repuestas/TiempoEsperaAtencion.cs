namespace Servicios.Interfaces.BonoDesempeno.Repuestas
{
    public class TiempoEsperaAtencion
    {
        public string NumeroDocumento { get; set; }
        public string FuenteFinanciamiento { get; set; }
        public string FechaTicket { get; set; }
        public string FechaAtencion { get; set; }
        public string TipoPaciente { get; set; }
        public string Especialidad { get; set; }
    }
}
