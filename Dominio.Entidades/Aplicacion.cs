using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Aplicacion : BaseGeneral
    {
        [Key]
        public int IdAplicacion { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
        [JsonIgnore]
        public virtual ICollection<Empleado> Empleado { get; set; }
        public Aplicacion()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    }
}
