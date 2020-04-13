using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class MuestraHemolizadaLipemica : BaseGeneral
    {
        [Key]
        public int IdMuestraHemolizadaLipemica { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        [StringLength(20)]
        public string TipoPrueba { get; set; }
        [Required]
        [StringLength(10)]
        public string HistoriaClinica { get; set; }
        [StringLength(10)]
        public string NumeroDocumento { get; set; }
        [Required]
        [StringLength(500)]
        public string Paciente { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
