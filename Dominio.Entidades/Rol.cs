using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Rol : BaseGeneral
    {
        [Key]
        public int IdRol { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [JsonIgnore]
        public virtual ICollection<Empleado> Empleado { get; set; }
        public Rol()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    }
}
