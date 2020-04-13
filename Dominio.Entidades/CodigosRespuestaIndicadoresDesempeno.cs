using Dominio.Entidades.Compartido;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class CodigosRespuestaIndicadoresDesempeno : BaseGeneral
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
