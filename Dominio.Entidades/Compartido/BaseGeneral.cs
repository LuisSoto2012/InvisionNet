using System;

namespace Dominio.Entidades.Compartido
{
    public class BaseGeneral
    {
        public int IdUsuarioCreacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool EsActivo { get; set; }

        public BaseGeneral()
        {
            this.FechaCreacion = DateTime.Now;
            this.EsActivo = true;
        }
    }
}
