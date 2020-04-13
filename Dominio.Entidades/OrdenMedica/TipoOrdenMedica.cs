using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class TipoOrdenMedica : BaseGeneral
    {
        [Key]
        public int IdTipoOrdenMedica { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public int IdEspecialidad { get; set; }
        public int TamanoFormulario { get; set; }
        [StringLength(100)]
        public string TituloFormulario { get; set; }
        [JsonIgnore]
        public virtual ICollection<TipoOrdenMedicaRangos> TipoOrdenMedicaRangos { get; set; }
    }
}
