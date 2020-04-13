using Dominio.Entidades.Compartido;
using Dominio.Entidades.Comunes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class TranscripcionErroneaInoportuna : BaseGeneral
    {
        [Key]
        public int IdTranscripcionErroneaInoportuna { get; set; }
        [Required]
        public DateTime FechaOcurrencia { get; set; }
        [Required]
        [StringLength(10)]
        public string HistoriaClinica { get; set; }
        [StringLength(10)]
        public string NumeroDocumento { get; set; }
        [Required]
        [StringLength(500)]
        public string Paciente { get; set; }
        [Required]
        public bool CuadernoOrden { get; set; }
        [Required]
        public bool OrdenSistema { get; set; }
        [Required]
        public bool EquipoCuaderno { get; set; }
        [Required]
        public bool Inoportuna { get; set; }
        public string Comentario { get; set; }
        [Required]
        public int IdAreaLaboratorio { get; set; }
        [JsonIgnore]
        public virtual AreaLaboratorio AreaLaboratorio { get; set; }
    }
}
