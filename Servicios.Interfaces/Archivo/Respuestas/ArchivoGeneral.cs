namespace Servicios.Interfaces.Archivo.Respuestas
{
    public class ArchivoGeneral
    {
        public int IdArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public int IdServicio { get; set; }
        public string HistoriaClinica { get; set; }
        public string NroDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public string ArchivoBinario { get; set; }
        public string Fecha { get; set; }
        public bool EsActivo { get; set; }
    }
}
