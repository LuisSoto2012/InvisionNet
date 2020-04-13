using Dominio.Entidades.Compartido;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.LaboratorioInmunologico
{
    public class IncidentesPacientes : BaseGeneral
    {
        [Key]
        public int IdIncidentesPacientes { get; set; }
        [Required]
        [StringLength(10)]
        public string HistoriaClinica { get; set; }
        [StringLength(10)]
        public string NumeroDocumento { get; set; }
        [Required]
        [StringLength(500)]
        public string Paciente { get; set; }
        public string Incidentes { get; set; }
        [Required]
        public DateTime FechaOcurrencia { get; set; }
    }
}
