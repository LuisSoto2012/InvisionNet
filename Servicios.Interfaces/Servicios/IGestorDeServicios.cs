using Servicios.Interfaces.Medico.Respuestas;
using Servicios.Interfaces.Servicios.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Servicios
{
    public interface IGestorDeServicios
    {
        List<ServicioPorEspecialidad> ListarServicioPorEspecialidad(MedicoPorEspecialidad especialidad);
    }
}
