namespace Servicios.Interfaces.Auditoria.Peticiones
{
    public class AuditoriaGeneral
    {
        public string Accion { get; set; }
        public string NombreTabla { get; set; }
        public string ValoresAntiguos { get; set; }
        public string ValoresNuevos { get; set; }
        public int IdUsuario { get; set; }
    }
}
