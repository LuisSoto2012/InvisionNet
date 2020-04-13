using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.Comunes
{
    public class TipoDocumentoIdentidad : BaseGeneral
    {
        [Key]
        public int IdTipoDocumentoIdentidad { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
