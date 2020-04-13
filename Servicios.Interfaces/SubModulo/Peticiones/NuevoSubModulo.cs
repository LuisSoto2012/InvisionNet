namespace Servicios.Interfaces.SubModulo.Peticiones
{
    public class NuevoSubModulo
    {
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public string Ruta { get; set; }
        public int IdModulo { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
