using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Procedimiento : BaseGeneral
    {
        [Key]
        public int IdProcedimiento { get; set; }
        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string DescripcionCorta { get; set; }
        [Required]
        public int IdEspecialidad { get; set; }
    }
}
