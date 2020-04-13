using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class OrdenesMedicasCodigos : BaseGeneral
    {
        [Key]
        public int IdOrdenesMedicasCodigos { get; set; }
        [Required]
        public int IdProcedimiento { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public int IdOrdenMedica { get; set; }
        [JsonIgnore]
        public OrdenesMedicas OrdenesMedicas { get; set; }
        [JsonIgnore]
        public virtual Procedimiento Procedimiento { get; set; }
        [JsonIgnore]
        public virtual ICollection<OpcionesOrdenMedica> OpcionesOrdenMedica { get; set; }
    }
}
