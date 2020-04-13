namespace Servicios.Interfaces.BonoDesempeno.Repuestas
{
    public class FormatoTrama
    {
        public int id_referencia { get; set; }
        public int id_cita { get; set; }
        public int tipo { get; set; }
        public object ipress { get; set; }
        public object paciente { get; set; }
        public object registro { get; set; }
    }
}
