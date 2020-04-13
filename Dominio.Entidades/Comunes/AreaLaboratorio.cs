using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.Comunes
{
    public class AreaLaboratorio : BaseGeneral
    {
        [Key]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [StringLength(5)]
        public string Codigo { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubModulo> SubModulos { get; set; }
        public AreaLaboratorio()
        {
            this.SubModulos = new HashSet<SubModulo>();
        }
    }
}
