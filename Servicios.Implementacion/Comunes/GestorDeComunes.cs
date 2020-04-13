using AutoMapper;
using Dominio.Contexto;
using Servicios.Interfaces.Comunes;
using Servicios.Interfaces.Comunes.Respuestas;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Servicios.Implementacion.Comunes
{
    public class GestorDeComunes : IGestorDeComunes
    {
        public List<ComboBox> ListarAreaLaboratorio(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.SubModulo.Where(x => x.IdSubModulo == Id)
                                   .FirstOrDefault()
                                   .AreaLaboratorios
                                   .Where(x => x.EsActivo == true)
                                   .ToList()
                                   .Select(x => Mapper.Map<ComboBox>(x))
                                   .ToList();
            }
        }

        public List<ComboBox> ListarCondicionTrabajo()
        {
            using (InoBD db = new InoBD())
            {
                return db.CondicionTrabajo.Where(x => x.EsActivo == true)
                                          .ToList()
                                          .Select(x => Mapper.Map<ComboBox>(x))
                                          .ToList();
            }
        }

        public List<ComboBox> ListarEspecialidades()
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<ComboBox>("dbo.Invision_EspecialidadesListar").ToList();
            }
        }

        public List<ComboBox> ListarPruebaLabotario(string Codigo)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<PruebaLaboratorio>("dbo.Invision_PruebasLaboratorioPorAreaListar @Codigo",
                        new SqlParameter("Codigo", Codigo)).ToList()
                        .Select(x => Mapper.Map<ComboBox>(x))
                        .ToList();
            }
        }

        public List<ComboBox> ListarServicioEspecialidad(int? Id)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<ComboBox>("dbo.Invision_ServicioEspecialidadListar @IdServicio",
                        new SqlParameter("IdServicio", Id)).ToList();
            }
        }

        public List<ComboBox> ListarTipoDocumentoIdentidad()
        {
            using (InoBD db = new InoBD())
            {
                return db.TipoDocumentoIdentidad.Where(x => x.EsActivo == true)
                                                .ToList()
                                                .Select(x => Mapper.Map<ComboBox>(x))
                                                .ToList();
            }
        }

        public List<ComboBox> ListarTipoEmpleado()
        {
            using (InoBD db = new InoBD())
            {
                return db.TipoEmpleado.Where(x => x.EsActivo == true)
                                      .ToList()
                                      .Select(x => Mapper.Map<ComboBox>(x))
                                      .ToList();
            }
        }

        public List<ComboBox> ListarUsuarioPorRol(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.Roles.Where(x => Id == null || x.IdRol == Id)
                                   .FirstOrDefault()
                                   .Empleado
                                   .Where(x => x.EsActivo == true)
                                   .ToList()
                                   .Select(x => Mapper.Map<ComboBox>(x))
                                   .ToList();
            }
        }

        public List<ComboBox> ListarAlmacenes()
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<ComboBox>("dbo.Invision_AlmacenesListar").ToList();
            }
        }

        public ComboBox ListarRespuestaIndicadoresDesempeno(string codigo)
        {
            using (InoBD db = new InoBD())
            {

                var codigoRespuesta =  db.CodigosRespuestaIndicadoresDesempeno.Where(x => x.EsActivo == true && x.Codigo == codigo).FirstOrDefault();
                return Mapper.Map<ComboBox>(codigoRespuesta);
            }
        }

        public List<ComboBox> ListarEscalafonDeLegajos()
        {
            using (InoBD db = new InoBD())
            {
                return db.EscalafonDeLegajos.Where(x => x.EsActivo == true)
                                            .ToList()
                                            .Select(x => Mapper.Map<ComboBox>(x))
                                            .ToList();
            }
        }

        public List<ComboBox> ListarCajeros()
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<ComboBox>("dbo.Invision_CajerosSeleccionarTodos").ToList();
            }
        }
    }
}
