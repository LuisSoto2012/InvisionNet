using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class EquipoUPS : BaseGeneral
    {
        [Key]
        public int IdEquipoUPS { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        public bool TieneUPS { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
