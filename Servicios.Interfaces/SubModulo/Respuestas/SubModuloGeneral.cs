namespace Servicios.Interfaces.SubModulo.Respuestas
{
    public class SubModuloGeneral
    {
        public int IdSubModulo { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public string Ruta { get; set; }
        public bool EsActivo { get; set; }
        public int IdModulo { get; set; }
        public bool ConPermisos { get; set; }
    }
}
