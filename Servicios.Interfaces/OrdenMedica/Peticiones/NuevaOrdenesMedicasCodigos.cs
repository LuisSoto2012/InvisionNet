using Servicios.Interfaces.Comunes;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Peticiones
{
    public class NuevaOrdenesMedicasCodigos
    {
        public int IdProcedimiento { get; set; }
        public string Descripcion { get; set; }
        public int IdOrdenMedica { get; set; }
        public List<ComboBox> OpcionesOrdenMedica { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
