using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class SueroMalReferenciado :  BaseGeneral
    {
        [Key]
        public int IdSueroMalReferenciado { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        public bool TieneReferencia { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        public string Observaciones { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
