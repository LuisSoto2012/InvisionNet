using Servicios.Interfaces.Atencion.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Respuestas
{
    public class TipoOrdenMedicaGeneral
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int IdEspecialidad { get; set; }
        public int TamanoFormulario { get; set; }
        public string TituloFormulario { get; set; }
        public List<ProcedimientoDto> Procedimiento { get; set; }
        public List<TipoOrdenMedicaRangosDto> TipoOrdenMedicaRangos { get; set; }
    }
}
