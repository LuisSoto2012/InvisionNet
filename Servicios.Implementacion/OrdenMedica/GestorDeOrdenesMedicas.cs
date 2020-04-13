using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Atencion.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.OrdenMedica;
using Servicios.Interfaces.OrdenMedica.Peticiones;
using Servicios.Interfaces.OrdenMedica.Respuestas;

namespace Servicios.Implementacion.OrdenMedica
{
    public class GestorDeOrdenesMedicas : IGestorDeOrdenesMedicas
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD AgregarOrdenMedica(NuevaOrdenMedica nuevaOrdenMedica)
        {
            using (InoBD db = new InoBD())
            {
                OrdenesMedicas pacienteEncontrado = db.OrdenesMedicas.Where(x => x.Fecha.Day == nuevaOrdenMedica.Fecha.Day &&
                                                        x.Fecha.Month == nuevaOrdenMedica.Fecha.Month &&
                                                        x.Fecha.Year == nuevaOrdenMedica.Fecha.Year &&
                                                        x.IdTipoOrdenMedica == nuevaOrdenMedica.IdTipoOrdenMedica &&
                                                        x.HistoriaClinica == nuevaOrdenMedica.HistoriaClinica).FirstOrDefault();
                if(pacienteEncontrado == null)
                {
                    if(nuevaOrdenMedica.OrdenesMedicasCodigos.Count > 0)
                    {
                        OrdenesMedicas ordenesMedicas = Mapper.Map<OrdenesMedicas>(nuevaOrdenMedica);
                        ordenesMedicas.OrdenesMedicasCodigos.Clear();
                        db.OrdenesMedicas.Add(ordenesMedicas);
                        db.SaveChanges();

                        foreach (NuevaOrdenesMedicasCodigos nuevaOrdenesMedicasCodigos in nuevaOrdenMedica.OrdenesMedicasCodigos)
                        {
                            OrdenesMedicasCodigos codigoExistente = db.OrdenesMedicasCodigos.Where(x => x.IdOrdenMedica == nuevaOrdenesMedicasCodigos.IdOrdenMedica && x.IdProcedimiento == nuevaOrdenesMedicasCodigos.IdProcedimiento).FirstOrDefault();
                            if(codigoExistente == null)
                            {
                                Procedimiento codigoValido = db.Procedimiento.Where(x => x.IdProcedimiento == nuevaOrdenesMedicasCodigos.IdProcedimiento).FirstOrDefault();
                                if(codigoValido != null)
                                {
                                    OrdenesMedicasCodigos ordenesMedicasCodigos = Mapper.Map<OrdenesMedicasCodigos>(nuevaOrdenesMedicasCodigos);
                                    ordenesMedicasCodigos.IdOrdenMedica = ordenesMedicas.IdOrdenMedica;
                                    ordenesMedicasCodigos.IdUsuarioCreacion = ordenesMedicas.IdUsuarioCreacion;
                                    ordenesMedicasCodigos.OpcionesOrdenMedica.Clear();
                                    db.OrdenesMedicasCodigos.Add(ordenesMedicasCodigos);

                                    if (nuevaOrdenesMedicasCodigos.OpcionesOrdenMedica.Count > 0)
                                    {
                                        List<int> idOpciones = nuevaOrdenesMedicasCodigos.OpcionesOrdenMedica.Select(r => r.Id).ToList();
                                        List<OpcionesOrdenMedica> opciones = db.OpcionesOrdenMedica.Where(r => idOpciones.Contains(r.IdOpcionOrdenMedica)).ToList();
                                        foreach (OpcionesOrdenMedica opcion in opciones)
                                        {
                                            ordenesMedicasCodigos.OpcionesOrdenMedica.Add(opcion);
                                        }
                                    }
                                    db.SaveChanges();
                                    //Mensaje de respuesta
                                    respuesta.Id = ordenesMedicas.IdOrdenMedica;
                                    respuesta.Mensaje = "Se creó la información correctamente.";
                                }
                                else
                                {
                                    //Mensaje de respuesta
                                    respuesta.Id = 0;
                                    respuesta.Mensaje = "El código que desea ingresar no existe.";
                                }
                            }
                        }
                    }
                    if(respuesta.Id > 0)
                    {
                        // Auditoria
                        AuditoriaGeneral auditoria = new AuditoriaGeneral
                        {
                            Accion = "Agregar",
                            NombreTabla = string.Concat("OrdenesMedicas|", nuevaOrdenMedica.IdTipoOrdenMedica),
                            ValoresAntiguos = null,
                            ValoresNuevos = JsonConvert.SerializeObject(nuevaOrdenMedica),
                            IdUsuario = nuevaOrdenMedica.IdUsuarioCreacion
                        };
                        this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                    }
                    else
                    {
                        //Mensaje de respuesta
                        respuesta.Id = 0;
                        respuesta.Mensaje = "No se encontró ningún código seleccionado.";
                    }
                    
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El paciente ya cuenta con esta orden médica en la fecha propuesta seleccionada, intente de nuevo.";
                }
            }
            return respuesta;
        }

        public List<OrdenMedicaGeneral> ListarOrdenesMedicas(int? IdUsuario, int? IdOrdenMedica)
        {
            using (InoBD db = new InoBD())
            {
                var opcionesOrdenesMedicas = db.OpcionesOrdenMedica.ToList();
                return db.OrdenesMedicas.Where(x => (IdUsuario == null || x.IdUsuarioCreacion == IdUsuario) && (IdOrdenMedica == null || x.IdOrdenMedica == IdOrdenMedica))
                                      .ToList()
                                      .Select(x => Mapper.Map<OrdenMedicaGeneral>(x))
                                      .ToList();
            }
        }

        public List<TipoOrdenMedicaGeneral> ListarTipoOrdenMedica(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                List<ProcedimientoDto> procedimientos = (from tomp in db.TipoOrdenMedica_Procedimiento
                                                         join p in db.Procedimiento on tomp.IdProcedimiento equals p.IdProcedimiento
                                                         where p.EsActivo == true
                                                         orderby tomp.Orden ascending
                                                         select new ProcedimientoDto
                                                         {
                                                             IdProcedimiento = tomp.IdProcedimiento,
                                                             IdTipoOrdenMedica = tomp.IdTipoOrdenMedica,
                                                             Codigo = p.Codigo,
                                                             Descripcion = p.Descripcion,
                                                             DescripcionCorta = p.DescripcionCorta
                                                         }).ToList();
                return db.TipoOrdenMedica.Where(x => x.EsActivo == true &&
                                   (Id == -1 || x.IdEspecialidad == Id) ||
                                   x.IdEspecialidad == -1
                                  )
                         .ToList()
                         .Select(x => new TipoOrdenMedicaGeneral
                         {
                             Id = x.IdTipoOrdenMedica,
                             Codigo = x.Descripcion.Replace(" ", ""),
                             Descripcion = x.Descripcion,
                             IdEspecialidad = x.IdEspecialidad,
                             TamanoFormulario = x.TamanoFormulario,
                             TituloFormulario = x.TituloFormulario,
                             Procedimiento = procedimientos.Where(y => y.IdTipoOrdenMedica == x.IdTipoOrdenMedica).ToList(),
                             TipoOrdenMedicaRangos = x.TipoOrdenMedicaRangos.Select(y => Mapper.Map<TipoOrdenMedicaRangosDto>(y)).ToList(),
                         })
                         .ToList();
            }
        }
    }
}
