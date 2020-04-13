using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class SubModulo : BaseGeneral
    {
        [Key]
        public int IdSubModulo { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public int Orden { get; set; }
        [Required]
        [StringLength(500)]
        public string Ruta { get; set; }
        [Required]
        public int IdModulo { get; set; }
        [JsonIgnore]
        public Modulo Modulo { get; set; }
        [JsonIgnore]
        public virtual ICollection<AreaLaboratorio> AreaLaboratorios { get; set; }
        [JsonIgnore]
        public virtual ICollection<Reporte> Reportes { get; set; }
        public SubModulo()
        {
            this.AreaLaboratorios = new HashSet<AreaLaboratorio>();
        }
    }
}
