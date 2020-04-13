using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class PocoFrecuente : BaseGeneral
    {
        [Key]
        public int IdPocoFrecuente { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        public int IdPrueba { get; set; }
        [Required]
        [StringLength(200)]
        public string NombrePrueba { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [Required]
        public int Total { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
