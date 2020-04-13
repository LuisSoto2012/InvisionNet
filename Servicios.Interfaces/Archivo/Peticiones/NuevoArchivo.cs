namespace Servicios.Interfaces.Archivo.Peticiones
{
    public class NuevoArchivo
    {
        public string TipoArchivo { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdServicio { get; set; }
        public string HistoriaClinica { get; set; }
        public string Ruta { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaCompleta { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
