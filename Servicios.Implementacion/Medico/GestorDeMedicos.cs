using Dominio.Contexto;
using Servicios.Interfaces.Medico;
using Servicios.Interfaces.Medico.Respuestas;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Servicios.Implementacion.Medico
{
    public class GestorDeMedicos : IGestorDeMedicos
    {
        public List<MedicoPorEspecialidad> ListarEspecialidadPorMedico(MedicoListar medico)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                List<MedicoPorEspecialidad> especialidades = null;
                if (medico.IdMedico == -1)
                {
                    especialidades = db.Database.SqlQuery<MedicoPorEspecialidad>("dbo.INO_CEEspecialidadesListar").ToList();
                }
                else
                {
                    especialidades = db.Database.SqlQuery<MedicoPorEspecialidad>("dbo.INO_CEMedicosEspecialidad @IdMedico",
                            new SqlParameter("IdMedico", medico.IdMedico)).ToList();
                }
                return especialidades;
            }
        }

        public List<MedicoListar> ListarMedicos(MedicoListar medico)
        {
            using(GalenPlusBD db = new GalenPlusBD())
            {
                var medicos = db.Database.SqlQuery<MedicoListar>("dbo.Invision_MedicosListar @IdEmpleado",
                        new SqlParameter("IdEmpleado", medico.IdEmpleado)).ToList();
                return medicos;
            }
        }

        public List<MedicoListar> ListarMedicosTicket()
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var medicos = db.Database.SqlQuery<MedicoListar>("dbo.Invision_MedicosTicketListar").ToList();
                return medicos;
            }
        }
    }
}
