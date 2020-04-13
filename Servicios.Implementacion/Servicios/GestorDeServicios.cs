using Dominio.Contexto;
using Servicios.Interfaces.Medico.Respuestas;
using Servicios.Interfaces.Servicios;
using Servicios.Interfaces.Servicios.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion.Servicios
{
    public class GestorDeServicios : IGestorDeServicios
    {
        public List<ServicioPorEspecialidad> ListarServicioPorEspecialidad(MedicoPorEspecialidad especialidad)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var servicios = db.Database.SqlQuery<ServicioPorEspecialidad>("dbo.INO_ConsultaExternaServiciosPorEspecialidad @IdEspecialidad",
                        new SqlParameter("IdEspecialidad", especialidad.IdEspecialidad)).ToList();
                return servicios;
            }
        }
    }
}
