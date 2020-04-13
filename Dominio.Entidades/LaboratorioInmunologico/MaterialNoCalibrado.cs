using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class MaterialNoCalibrado : BaseGeneral
    {
        [Key]
        public int IdMaterialNoCalibrado { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [Required]
        public int Calibrado { get; set; }
        [Required]
        public int NoCalibrado { get; set; }
        [Required]
        public int Inoperativo { get; set; }
        [Required]
        public int Total { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
