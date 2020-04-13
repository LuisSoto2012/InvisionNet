using Servicios.Interfaces.Medico.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Medico
{
    public interface IGestorDeMedicos
    {
        List<MedicoListar> ListarMedicos(MedicoListar medico);
        List<MedicoListar> ListarMedicosTicket(); 
        List<MedicoPorEspecialidad> ListarEspecialidadPorMedico(MedicoListar medico);
    }
}
