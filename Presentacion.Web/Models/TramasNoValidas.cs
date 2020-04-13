using Servicios.Interfaces.BonoDesempeno.Repuestas;

namespace Presentacion.Web.Models
{
    public class TramasNoValidas
    {
        public int IdCita { get; set; }
        public string MensajeError { get; set; }
        public FormatoTrama FormatoTrama { get; set; }
    }
}