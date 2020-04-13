using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class RendimientoHoraTrabajador : BaseGeneral
    {
        [Key]
        public int IdRendimientoHoraTrabajador { get; set; }
        [Required]
        public int NumeroMes { get; set; }
        [Required]
        public int Horas { get; set; }
        [Required]
        public int ExamenesProcesados { get; set; }
        [Required]
        public int NumeroTrabajadores { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
