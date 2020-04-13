using Servicios.Interfaces.Atencion.Respuestas;
using Servicios.Interfaces.Comunes;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Respuestas
{
    public class OrdenesMedicasCodigosGeneral
    {
        public int IdOrdenesMedicasCodigos { get; set; }
        public string Descripcion { get; set; }
        public int IdOrdenMedica { get; set; }
        public ProcedimientoDto Procedimiento { get; set; }
        public List<ComboBox> OpcionesOrdenMedica { get; set; }
    }
}
