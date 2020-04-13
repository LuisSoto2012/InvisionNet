using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class OpcionesOrdenMedica : BaseGeneral
    {
        [Key]
        public int IdOpcionOrdenMedica { get; set; }
        public string Descripcion { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrdenesMedicasCodigos> OrdenesMedicasCodigos { get; set; }
    }
}
