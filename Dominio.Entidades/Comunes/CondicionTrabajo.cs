using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.Comunes
{
    public class CondicionTrabajo : BaseGeneral
    {
        [Key]
        public int IdCondicionTrabajo { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
