using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class TipoOrdenMedicaRangos : BaseGeneral
    {
        [Key]
        public int IdTipoOrdenMedicaRangos { get; set; }
        [Required]
        public int Inicial { get; set; }
        [Required]
        public int Final { get; set; }
        [StringLength(500)]
        public string Condicionales { get; set; }
        [Required]
        public int IdTipoOrdenMedica { get; set; }
        [JsonIgnore]
        public TipoOrdenMedica TipoOrdenMedica { get; set; }
    }
}
