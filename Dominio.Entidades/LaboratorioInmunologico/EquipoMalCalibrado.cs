using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class EquipoMalCalibrado : BaseGeneral
    {
        [Key]
        public int IdEquipoMalCalibrado { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        public int TotalDeEquipos { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [Required]
        public int Inadecuados { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
