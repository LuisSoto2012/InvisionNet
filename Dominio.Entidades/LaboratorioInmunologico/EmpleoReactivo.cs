using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class EmpleoReactivo : BaseGeneral
    {
        [Key]
        public int IdEmpleoReactivo{ get; set; }
        [Required]
        public int TotalDeReactivos { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [Required]
        public int Vencidos { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
