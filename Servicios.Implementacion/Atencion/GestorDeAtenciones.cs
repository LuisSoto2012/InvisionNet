using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Atencion;
using Servicios.Interfaces.Atencion.Peticiones;
using Servicios.Interfaces.Atencion.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;

namespace Servicios.Implementacion.Atencion
{
    public class GestorDeAtenciones : IGestorDeAtenciones
    {
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public List<CitadosPorFecha> ListarCitadosPorFecha(CitasPor citasPor)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<CitadosPorFecha>("dbo.Invision_CECitadosPorFecha @FechaDesde,@FechaHasta,@IdMedico",
                            new SqlParameter("FechaDesde", citasPor.FechaDesde),
                            new SqlParameter("FechaHasta", citasPor.FechaHasta),
                            new SqlParameter("IdMedico", citasPor.IdMedico)
                        ).ToList();
            }
        }

        public List<CitadosPorFechaMedicoEspecialidad> ListarCitadosPorFechaMedicoEspecialidad(PacientesPor PacientesPor)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<CitadosPorFechaMedicoEspecialidad>("dbo.Invision_CECitadosPorFechaMedicoEspecialidad @IdMedico,@IdEspecialidad,@Fecha",
                            new SqlParameter("IdMedico", PacientesPor.IdMedico),
                            new SqlParameter("IdEspecialidad", PacientesPor.IdEspecialidad),
                            new SqlParameter("Fecha", PacientesPor.Fecha)
                        ).ToList();
            }
        }

        public List<AtencionFiltro> ListarAtenciones(AtencionesPor atencionesPor)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<AtencionFiltro>("dbo.Invision_CEPacientesAtendidosListar @Fecha,@IdEspecialidad,@IdServicio,@IdMedico",
                            new SqlParameter("Fecha", atencionesPor.Fecha),
                            new SqlParameter("IdEspecialidad", atencionesPor.IdEspecialidad),
                            new SqlParameter("IdServicio", atencionesPor.IdServicio),
                            new SqlParameter("IdMedico", atencionesPor.IdMedico)
                        ).ToList();
            }
        }

        public List<Diagnostico> ListarDiagnosticos(Diagnostico diagnostico)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<Diagnostico>("dbo.INO_CiruDiagnosticos @Diag,@Descripcion",
                            new SqlParameter("Diag", diagnostico.CodigoCIE10),
                            new SqlParameter("Descripcion", diagnostico.Descripcion)
                        ).ToList();
            }
        }

        public List<ProcedimientoDto> ListarProcedimientos(ProcedimientoDto procedimiento)
        {
            //dbo.INO_ProcedimientosListarPorFiltro @codigo, @descripcion
            using (InoBD db = new InoBD())
            {
                return db.Procedimiento.Where(x => x.EsActivo == true &&
                                                   (procedimiento.Codigo == "" || x.Codigo == procedimiento.Codigo) &&
                                                   (procedimiento.Descripcion == "" || x.Descripcion.Contains(procedimiento.Descripcion)))
                                                   .ToList()
                                                   .Select(x => Mapper.Map<ProcedimientoDto>(x))
                                                   .ToList();
            }
        }

        public RespuestaBD RegistrarAtencion(RegistroAtencion registroAtencion)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                db.Database.ExecuteSqlCommand("dbo.INO_CEAtencionesRegistrar @IdCita,@NroHistoriaClinica,@Paciente,@IdMedico,@Medico,@IdEspecialidad,@Especialidad,@IdServicio,@Servicio,@Financiamiento," +
                    "@Diacod1,@Diades1,@IdTipoDiagnostico1,@Diacod2,@Diades2,@IdTipoDiagnostico2,@Diacod3,@Diades3,@IdTipoDiagnostico3,@FechaAtencion,@IdUsuario,@Usuario,@CodProc1,@Coddes1,@CodProc2," +
                    "@Coddes2,@CodProc3,@Coddes3,@IdResidente,@Residente,@IdTipoCondicionEstablecimiento,@IdTipoCondicionServicio,@Diacod1_OI,@Diades1_OI,@IdTipoDiagnostico1_OI,@Diacod2_OI,@Diades2_OI," +
                    "@IdTipoDiagnostico2_OI,@Diacod3_OI,@Diades3_OI,@IdTipoDiagnostico3_OI,@CodProc1_OI,@Coddes1_OI,@CodProc2_OI,@Coddes2_OI,@CodProc3_OI,@Coddes3_OI,@AVOD,@AVOI",
                    new SqlParameter("IdCita", registroAtencion.IdCita),
                    new SqlParameter("NroHistoriaClinica", registroAtencion.NroHistoriaClinica),
                    new SqlParameter("Paciente", registroAtencion.Paciente),
                    new SqlParameter("IdMedico", registroAtencion.IdMedico),
                    new SqlParameter("Medico", registroAtencion.Medico),
                    new SqlParameter("IdEspecialidad", registroAtencion.IdEspecialidad),
                    new SqlParameter("Especialidad", registroAtencion.Especialidad),
                    new SqlParameter("IdServicio", registroAtencion.IdServicio),
                    new SqlParameter("Servicio", registroAtencion.Servicio),
                    new SqlParameter("Financiamiento", registroAtencion.Financiamiento),
                    new SqlParameter("Diacod1", registroAtencion.Diacod1),
                    new SqlParameter("Diades1", registroAtencion.Diades1),
                    new SqlParameter("IdTipoDiagnostico1", registroAtencion.IdTipoDiagnostico1),
                    new SqlParameter("Diacod2", registroAtencion.Diacod2),
                    new SqlParameter("Diades2", registroAtencion.Diades2),
                    new SqlParameter("IdTipoDiagnostico2", registroAtencion.IdTipoDiagnostico2),
                    new SqlParameter("Diacod3", registroAtencion.Diacod3),
                    new SqlParameter("Diades3", registroAtencion.Diades3),
                    new SqlParameter("IdTipoDiagnostico3", registroAtencion.IdTipoDiagnostico3),
                    new SqlParameter("FechaAtencion", registroAtencion.FechaAtencion),
                    new SqlParameter("IdUsuario", registroAtencion.IdUsuario),
                    new SqlParameter("Usuario", registroAtencion.Usuario),
                    new SqlParameter("CodProc1", registroAtencion.CodProc1),
                    new SqlParameter("Coddes1", registroAtencion.Coddes1),
                    new SqlParameter("CodProc2", registroAtencion.CodProc2),
                    new SqlParameter("Coddes2", registroAtencion.Coddes2),
                    new SqlParameter("CodProc3", registroAtencion.CodProc3),
                    new SqlParameter("Coddes3", registroAtencion.Coddes3),
                    new SqlParameter("IdResidente", registroAtencion.IdResidente),
                    new SqlParameter("Residente", registroAtencion.Residente),
                    new SqlParameter("IdTipoCondicionEstablecimiento", registroAtencion.IdTipoCondicionEstablecimiento),
                    new SqlParameter("IdTipoCondicionServicio", registroAtencion.IdTipoCondicionServicio),
                    new SqlParameter("Diacod1_OI", registroAtencion.Diacod1_OI),
                    new SqlParameter("Diades1_OI", registroAtencion.Diades1_OI),
                    new SqlParameter("IdTipoDiagnostico1_OI", registroAtencion.IdTipoDiagnostico1_OI),
                    new SqlParameter("codigo", registroAtencion.IdCita),
                    new SqlParameter("Diacod2_OI", registroAtencion.Diacod2_OI),
                    new SqlParameter("Diades2_OI", registroAtencion.Diades2_OI),
                    new SqlParameter("IdTipoDiagnostico2_OI", registroAtencion.IdTipoDiagnostico2_OI),
                    new SqlParameter("Diacod3_OI", registroAtencion.Diacod3_OI),
                    new SqlParameter("Diades3_OI", registroAtencion.Diades3_OI),
                    new SqlParameter("IdTipoDiagnostico3_OI", registroAtencion.IdTipoDiagnostico3_OI),
                    new SqlParameter("CodProc1_OI", registroAtencion.CodProc1_OI),
                    new SqlParameter("Coddes1_OI", registroAtencion.Coddes1_OI),
                    new SqlParameter("CodProc2_OI", registroAtencion.CodProc2_OI),
                    new SqlParameter("Coddes2_OI", registroAtencion.Coddes2_OI),
                    new SqlParameter("CodProc3_OI", registroAtencion.CodProc3_OI),
                    new SqlParameter("Coddes3_OI", registroAtencion.Coddes3_OI),
                    new SqlParameter("AVOD", registroAtencion.Avod),
                    new SqlParameter("AVOI", registroAtencion.Avoi));

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "Atención",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(registroAtencion),
                    IdUsuario = registroAtencion.IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return new RespuestaBD
                {
                    Id = 1,
                    Mensaje = "Se guardó correctamente la atención"
                };
            }
        }

        public RespuestaBD ActualizarAtencion(RegistroAtencion registroAtencion)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                db.Database.ExecuteSqlCommand("dbo.INO_CEAtencionesActualizar @Id,@IdCita,@NroHistoriaClinica,@Paciente,@IdMedico,@Medico,@IdEspecialidad,@Especialidad,@IdServicio,@Servicio,@Financiamiento," +
                    "@Diacod1,@Diades1,@IdTipoDiagnostico1,@Diacod2,@Diades2,@IdTipoDiagnostico2,@Diacod3,@Diades3,@IdTipoDiagnostico3,@FechaAtencion,@IdUsuario,@Usuario,@CodProc1,@Coddes1,@CodProc2," +
                    "@Coddes2,@CodProc3,@Coddes3,@IdResidente,@Residente,@IdTipoCondicionEstablecimiento,@IdTipoCondicionServicio,@Diacod1_OI,@Diades1_OI,@IdTipoDiagnostico1_OI,@Diacod2_OI,@Diades2_OI," +
                    "@IdTipoDiagnostico2_OI,@Diacod3_OI,@Diades3_OI,@IdTipoDiagnostico3_OI,@CodProc1_OI,@Coddes1_OI,@CodProc2_OI,@Coddes2_OI,@CodProc3_OI,@Coddes3_OI,@AVOD,@AVOI",
                    new SqlParameter("Id", registroAtencion.Id),
                    new SqlParameter("IdCita", registroAtencion.IdCita),
                    new SqlParameter("NroHistoriaClinica", registroAtencion.NroHistoriaClinica),
                    new SqlParameter("Paciente", registroAtencion.Paciente),
                    new SqlParameter("IdMedico", registroAtencion.IdMedico),
                    new SqlParameter("Medico", registroAtencion.Medico),
                    new SqlParameter("IdEspecialidad", registroAtencion.IdEspecialidad),
                    new SqlParameter("Especialidad", registroAtencion.Especialidad),
                    new SqlParameter("IdServicio", registroAtencion.IdServicio),
                    new SqlParameter("Servicio", registroAtencion.Servicio),
                    new SqlParameter("Financiamiento", registroAtencion.Financiamiento),
                    new SqlParameter("Diacod1", registroAtencion.Diacod1),
                    new SqlParameter("Diades1", registroAtencion.Diades1),
                    new SqlParameter("IdTipoDiagnostico1", registroAtencion.IdTipoDiagnostico1),
                    new SqlParameter("Diacod2", registroAtencion.Diacod2),
                    new SqlParameter("Diades2", registroAtencion.Diades2),
                    new SqlParameter("IdTipoDiagnostico2", registroAtencion.IdTipoDiagnostico2),
                    new SqlParameter("Diacod3", registroAtencion.Diacod3),
                    new SqlParameter("Diades3", registroAtencion.Diades3),
                    new SqlParameter("IdTipoDiagnostico3", registroAtencion.IdTipoDiagnostico3),
                    new SqlParameter("FechaAtencion", registroAtencion.FechaAtencion),
                    new SqlParameter("IdUsuario", registroAtencion.IdUsuario),
                    new SqlParameter("Usuario", registroAtencion.Usuario),
                    new SqlParameter("CodProc1", registroAtencion.CodProc1),
                    new SqlParameter("Coddes1", registroAtencion.Coddes1),
                    new SqlParameter("CodProc2", registroAtencion.CodProc2),
                    new SqlParameter("Coddes2", registroAtencion.Coddes2),
                    new SqlParameter("CodProc3", registroAtencion.CodProc3),
                    new SqlParameter("Coddes3", registroAtencion.Coddes3),
                    new SqlParameter("IdResidente", registroAtencion.IdResidente),
                    new SqlParameter("Residente", registroAtencion.Residente),
                    new SqlParameter("IdTipoCondicionEstablecimiento", registroAtencion.IdTipoCondicionEstablecimiento),
                    new SqlParameter("IdTipoCondicionServicio", registroAtencion.IdTipoCondicionServicio),
                    new SqlParameter("Diacod1_OI", registroAtencion.Diacod1_OI),
                    new SqlParameter("Diades1_OI", registroAtencion.Diades1_OI),
                    new SqlParameter("IdTipoDiagnostico1_OI", registroAtencion.IdTipoDiagnostico1_OI),
                    new SqlParameter("codigo", registroAtencion.IdCita),
                    new SqlParameter("Diacod2_OI", registroAtencion.Diacod2_OI),
                    new SqlParameter("Diades2_OI", registroAtencion.Diades2_OI),
                    new SqlParameter("IdTipoDiagnostico2_OI", registroAtencion.IdTipoDiagnostico2_OI),
                    new SqlParameter("Diacod3_OI", registroAtencion.Diacod3_OI),
                    new SqlParameter("Diades3_OI", registroAtencion.Diades3_OI),
                    new SqlParameter("IdTipoDiagnostico3_OI", registroAtencion.IdTipoDiagnostico3_OI),
                    new SqlParameter("CodProc1_OI", registroAtencion.CodProc1_OI),
                    new SqlParameter("Coddes1_OI", registroAtencion.Coddes1_OI),
                    new SqlParameter("CodProc2_OI", registroAtencion.CodProc2_OI),
                    new SqlParameter("Coddes2_OI", registroAtencion.Coddes2_OI),
                    new SqlParameter("CodProc3_OI", registroAtencion.CodProc3_OI),
                    new SqlParameter("Coddes3_OI", registroAtencion.Coddes3_OI),
                    new SqlParameter("AVOD", registroAtencion.Avod),
                    new SqlParameter("AVOI", registroAtencion.Avoi));

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Actulizar",
                    NombreTabla = "Atención",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(registroAtencion),
                    IdUsuario = registroAtencion.IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return new RespuestaBD
                {
                    Id = 1,
                    Mensaje = "Se guardó correctamente la atención"
                };
            }
        }


    }
}
