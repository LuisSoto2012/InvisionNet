using Servicios.Interfaces.SubModulo.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Modulo.Respuestas
{
    public class ModuloGeneral
    {
        public int IdModulo { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }
        public bool EsActivo { get; set; }
        public List<SubModuloGeneral> SubModulo { get; set; }
    }
}
