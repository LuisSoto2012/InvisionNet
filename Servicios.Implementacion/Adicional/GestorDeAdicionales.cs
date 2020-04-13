using Dominio.Contexto;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Adicional;
using Servicios.Interfaces.Adicional.Peticiones;
using Servicios.Interfaces.Adicional.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Paciente.Peticiones;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Servicios.Implementacion.Adicional
{
    public class GestorDeAdicionales : IGestorDeAdicionales
    {
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public List<Adicionales> ConsultaExternaAdicionalesPorMedicoListar(BuscarPaciente paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var adicionales = db.Database.SqlQuery<Adicionales>("dbo.INO_ConsultaExternaAdicionalesPorMedicoListar @Idmedico, @Fecha, @IdEspecialidad",
                        new SqlParameter("IdMedico", paciente.IdMedico),
                        new SqlParameter("Fecha", paciente.Fecha),
                        new SqlParameter("IdEspecialidad", paciente.IdEspecialidad)).ToList();
                return adicionales;
            }
        }

        public int ConsultaExternaAdicionalesPorMedicoRegistrar(NuevaAdicional nuevaAdicional)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                int adicional = db.Database.SqlQuery<int>("dbo.INO_ConsultaExternaAdicionalesPorMedicoRegistrar @Hc,@Paciente,@IdEspecialidad,@IdServicio,@IdMedico,@FechaAdicional,@FechaRegistro,@IdUsuario",
                        new SqlParameter("Hc", nuevaAdicional.Hc),
                        new SqlParameter("Paciente", nuevaAdicional.Paciente),
                        new SqlParameter("IdEspecialidad", nuevaAdicional.IdEspecialidad),
                        new SqlParameter("IdServicio", nuevaAdicional.IdServicio),
                        new SqlParameter("IdMedico", nuevaAdicional.IdMedico),
                        new SqlParameter("FechaAdicional", nuevaAdicional.FechaAdicional),
                        new SqlParameter("FechaRegistro", nuevaAdicional.FechaRegistro),
                        new SqlParameter("IdUsuario", nuevaAdicional.IdUsuario)).FirstOrDefault();

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "CitaAdicional",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevaAdicional),
                    IdUsuario = nuevaAdicional.IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return adicional;
            }
        }
    }
}
