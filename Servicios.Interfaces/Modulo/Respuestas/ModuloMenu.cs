using Servicios.Interfaces.SubModulo.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Modulo.Respuestas
{
    public class ModuloMenu
    {
        public int IdModulo { get; set; }
        public string Modulo { get; set; }
        public string Icono { get; set; }
        public int Orden { get; set; }
        public List<SubModuloMenu> SubModulo { get; set; }
    }
}
