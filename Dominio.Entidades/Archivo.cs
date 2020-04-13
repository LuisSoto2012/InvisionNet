using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Archivo : BaseGeneral
    {
        [Key]
        public int IdArchivo { get; set; }
        [Required]
        [StringLength(3)]
        public string TipoArchivo { get; set; }
        [Required]
        public int IdEspecialidad { get; set; }
        [Required]
        public int IdServicio { get; set; }
        [Required]
        [StringLength(10)]
        public string HistoriaClinica { get; set; }
        [Required]
        public string Ruta { get; set; }
        [Required]
        [StringLength(200)]
        public string NombreArchivo { get; set; }
        [Required]
        public string RutaCompleta { get; set; }
        public string NroDocumento { get; set; }
    }
}
