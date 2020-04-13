using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Modulo : BaseGeneral
    {
        [Key]
        public int IdModulo { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public int Orden { get; set; }
        [Required]
        [StringLength(50)]
        public string Icono { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubModulo> SubModulo { get; set; }
    }
}
