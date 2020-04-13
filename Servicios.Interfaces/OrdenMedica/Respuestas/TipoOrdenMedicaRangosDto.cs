using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Respuestas
{
    public class TipoOrdenMedicaRangosDto
    {
        public int IdTipoOrdenMedicaRangos { get; set; }
        public int Inicial { get; set; }
        public int Final { get; set; }
        public List<string> Condicionales { get; set; }
    }
}
