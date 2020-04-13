using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Reporte : BaseGeneral
    {
        [Key]
        public int IdReporte { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public string NombreSSRS { get; set; }
        [Required]
        [StringLength(200)]
        public string Imagen { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Ancho { get; set; }
        [Required]
        public int TamanoDialog { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubModulo> SubModulos { get; set; }
    }
}
