using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.Comunes
{
    public class TipoEmpleado : BaseGeneral
    {
        [Key]
        public int IdTipoEmpleado { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
