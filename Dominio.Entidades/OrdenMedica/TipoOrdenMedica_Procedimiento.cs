using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class TipoOrdenMedica_Procedimiento
    {
        [Key]
        public int Id { get; set; }
        // Set the column order so it appears nice in the database
        public int IdTipoOrdenMedica { get; set; }
        public int IdProcedimiento { get; set; }
        // Add the navigation properties
        [JsonIgnore]
        public virtual TipoOrdenMedica TipoOrdenMedicas { get; set; }
        [JsonIgnore]
        public virtual Procedimiento Procedimientos { get; set; }
        // Add any additional fields you need
        public int Orden { get; set; }
    }
}
