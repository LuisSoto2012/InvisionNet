using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dominio.Contexto;
using Servicios.Interfaces.BonoDesempeno;
using Servicios.Interfaces.BonoDesempeno.Peticiones;
using Servicios.Interfaces.BonoDesempeno.Repuestas;

namespace Servicios.Implementacion.BonoDesempeno
{
    public class GestorDeBonoDesempeno : IGestorDeBonoDesempeno
    {
        public List<FormatoTrama> ListarDiferimientoCitas(DatosTramaBono datosTramaBono)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<DiferimientoCitas>("dbo.Invision_BonoDesempenoDiferimiento @FechaDesde, @FechaHasta, @IdEspecialidad, @Tipo_Paciente",
                        new SqlParameter("FechaDesde", datosTramaBono.FechaDesde),
                        new SqlParameter("FechaHasta", datosTramaBono.FechaHasta),
                        new SqlParameter("IdEspecialidad", datosTramaBono.IdEspecialidad),
                        new SqlParameter("Tipo_Paciente", datosTramaBono.Tipo_Paciente)).ToList()
                        .Select(x => new FormatoTrama
                        {
                            id_referencia = x.id_referencia,
                            id_cita = x.idCita,
                            tipo = x.tipo,
                            ipress = new
                            {
                                ipress_id = x.ipress_id,
                                diresa_id = x.diressa_id,
                                red_id = x.red_id,
                                microred_id = x.microred_id
                            },
                            paciente = new
                            {
                                seguro_sis = x.seguro_sis,
                                documento = new
                                {
                                    tipo = x.documento_tipo,
                                    numero = x.documento_numero
                                },
                                nombre = new
                                {
                                    prenombres = x.nombre_prenombres,
                                    apellido_paterno = x.nombre_paterno,
                                    apellido_materno = x.nombre_materno
                                },
                                ubigeo_domicilio = new
                                {
                                    departamento_id = x.departamento_id,
                                    provincia_id = x.provincia_id,
                                    distrito_id = x.distrito_id
                                }
                            },
                            registro = new
                            {
                                inicio = x.fecha_inicio,
                                fin = x.fecha_fin
                            }
                        })
                        .Where(x => datosTramaBono.Selected.Contains(x.id_cita))
                        .ToList();
            }
        }

        public List<FormatoTramaConDias> ListarDiferimientoCitasConDias(DatosTramaBono datosTramaBono)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<DiferimientoCitas>("dbo.Invision_BonoDesempenoDiferimiento @FechaDesde, @FechaHasta, @IdEspecialidad, @Tipo_Paciente",
                        new SqlParameter("FechaDesde", datosTramaBono.FechaDesde),
                        new SqlParameter("FechaHasta", datosTramaBono.FechaHasta),
                        new SqlParameter("IdEspecialidad", datosTramaBono.IdEspecialidad),
                        new SqlParameter("Tipo_Paciente", datosTramaBono.Tipo_Paciente)).ToList()
                        .Select(x => new FormatoTramaConDias
                        {
                            id_referencia = x.id_referencia,
                            id_cita = x.idCita,
                            tipo = x.tipo,
                            dias = x.dias,
                            ipress = new
                            {
                                ipress_id = x.ipress_id,
                                diresa_id = x.diressa_id,
                                red_id = x.red_id,
                                microred_id = x.microred_id
                            },
                            paciente = new
                            {
                                seguro_sis = x.seguro_sis,
                                documento = new
                                {
                                    tipo = x.documento_tipo,
                                    numero = x.documento_numero
                                },
                                nombre = new
                                {
                                    prenombres = x.nombre_prenombres,
                                    apellido_paterno = x.nombre_paterno,
                                    apellido_materno = x.nombre_materno
                                },
                                ubigeo_domicilio = new
                                {
                                    departamento_id = x.departamento_id,
                                    provincia_id = x.provincia_id,
                                    distrito_id = x.distrito_id
                                }
                            },
                            registro = new
                            {
                                inicio = x.fecha_inicio,
                                fin = x.fecha_fin
                            }
                        }).ToList();
            }
        }

        public List<TiempoEsperaAtencion> ListarTiempoEsperaAtencion(DatosTramaBono datosTramaBono)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<TiempoEsperaAtencion>("dbo.Invision_IndicadoresDeDesempeno @FechaDesde, @FechaHasta, @IdEspecialidad",
                        new SqlParameter("FechaDesde", datosTramaBono.FechaDesde),
                        new SqlParameter("FechaHasta", datosTramaBono.FechaHasta),
                        new SqlParameter("IdEspecialidad", datosTramaBono.IdEspecialidad)).ToList();
            }
        }
    }
}
