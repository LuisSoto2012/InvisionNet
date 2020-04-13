namespace Presentacion.Web.Models
{
    public class RespuestaDeLogin
    {
        public string Token { get; set; }
        public bool FueExitosa { get; set; }
        public string Mensaje { get; set; }
    }
}