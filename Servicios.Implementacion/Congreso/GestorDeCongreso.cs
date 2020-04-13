using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Congreso;
using Servicios.Interfaces.Congreso.Peticiones;
using Servicios.Interfaces.Congreso.Respuestas;

namespace Servicios.Implementacion.Congreso
{
    public class GestorDeCongreso : IGestorDeCongreso
    {
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public List<AsistenciaGeneral> EventoAsistenciaListar(int IdHorario, int IdEvento)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<AsistenciaGeneral>("dbo.INO_EventoAsistenciaListar @IdHorario, @IdEvento",
                        new SqlParameter("IdHorario", IdHorario),
                        new SqlParameter("IdEvento", IdEvento)).ToList();
            }
        }

        public RespuestaBD EventoAsistenciaRegistrar(NuevaAsistencia nuevaAsistencia)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                int IdRegistro = db.Database.SqlQuery<int>("dbo.INO_EventoAsistenciaRegistrar @IdEvento, @IdParticipante, @IdHorario, @FechaRegistro, @IdUsuario",
                        new SqlParameter("IdEvento", nuevaAsistencia.IdEvento),
                        new SqlParameter("IdParticipante", nuevaAsistencia.IdParticipante),
                        new SqlParameter("IdHorario", nuevaAsistencia.IdHorario),
                        new SqlParameter("FechaRegistro", nuevaAsistencia.FechaRegistro),
                        new SqlParameter("IdUsuario", nuevaAsistencia.IdUsuario)).FirstOrDefault();

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "EventoAsistencia",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevaAsistencia),
                    IdUsuario = nuevaAsistencia.IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return new RespuestaBD
                {
                    Id = IdRegistro,
                    Mensaje = IdRegistro > 0 ? "Se guardó correctamente la atención." : "El participante ya ha sido registrado para este horario."
                };
            }
        }

        public List<EventoGeneral> EventoListar()
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<EventoGeneral>("dbo.INO_EventoListar").ToList();
            }
        }

        public ParticipanteGeneral EventoParticipanteXDNI(string NumeroDocumento)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<ParticipanteGeneral>("dbo.INO_EventoParticipanteXDNI @Dni",
                        new SqlParameter("Dni", NumeroDocumento)).FirstOrDefault();
            }
        }
    }
}
