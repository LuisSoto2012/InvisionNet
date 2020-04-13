using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Medico;
using Servicios.Interfaces.Medico.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class MedicoController : ApiController
    {
        IGestorDeMedicos _gestorDeMedicos;

        public MedicoController(IGestorDeMedicos gestorDeMedicos)
        {
            this._gestorDeMedicos = gestorDeMedicos;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<MedicoListar> ListarMedicosTicket()
        {
            return _gestorDeMedicos.ListarMedicosTicket();
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<MedicoListar> ListarMedicos(MedicoListar medico)
        {
            return _gestorDeMedicos.ListarMedicos(medico);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<MedicoPorEspecialidad> ListarEspecialidadPorMedico(MedicoListar medico)
        {
            return _gestorDeMedicos.ListarEspecialidadPorMedico(medico);
        }
    }
}
