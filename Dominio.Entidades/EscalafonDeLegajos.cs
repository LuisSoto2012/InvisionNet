using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class EscalafonDeLegajos : BaseGeneral
    {
        [Key]
        public int IdEscalafonDeLegajos { get; set; }
        [Required]
        [StringLength(3)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(20)]
        public string Seccion { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
