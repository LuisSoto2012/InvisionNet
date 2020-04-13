using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Servicios.Interfaces.Reporte;
using Servicios.Interfaces.Reporte.Respuestas;

namespace Servicios.Implementacion.Reporte
{
    public class GestorDeReportes : IGestorDeReportes
    {
        public List<ReporteGeneral> ListarReportes(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.SubModulo.Where(x => x.IdSubModulo == Id)
                                   .FirstOrDefault()
                                   .Reportes
                                   .Where(x => x.EsActivo == true)
                                   .ToList()
                                   .Select(x => Mapper.Map<ReporteGeneral>(x))
                                   .ToList();
            }
        }
    }
}
