using Servicios.Interfaces.Reporte.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Reporte
{
    public interface IGestorDeReportes
    {
        List<ReporteGeneral> ListarReportes(int? Id); 
    }
}
