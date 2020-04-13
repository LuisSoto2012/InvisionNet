using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Dominio.Entidades.LaboratorioInmunologico;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;

namespace Servicios.Implementacion.Laboratorio
{
    public class GestorDeIndicadoresGestion : IGestorDeIndicadoresGestion
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD AgregarRendimientoHoraTrabajador(NuevoRendimientoHoraTrabajador nuevoRendimientoHoraTrabajador)
        {
            using (InoBD db = new InoBD())
            {
                RendimientoHoraTrabajador rendimientoHoraTrabajador = Mapper.Map<RendimientoHoraTrabajador>(nuevoRendimientoHoraTrabajador);
                db.RendimientoHoraTrabajador.Add(rendimientoHoraTrabajador);
                db.SaveChanges();

                //Mensaje de respuesta
                respuesta.Id = rendimientoHoraTrabajador.IdRendimientoHoraTrabajador;
                respuesta.Mensaje = "Se ingresó los datos correctamente.";

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "RendimientoHoraTrabajador",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoRendimientoHoraTrabajador),
                    IdUsuario = nuevoRendimientoHoraTrabajador.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public RespuestaBD EditarRendimientoHoraTrabajador(ActualizarRendimientoHoraTrabajador actualizarRendimientoHoraTrabajador)
        {
            using (InoBD db = new InoBD())
            {
                RendimientoHoraTrabajador rendimientoHoraTrabajador = db.RendimientoHoraTrabajador.Find(actualizarRendimientoHoraTrabajador.IdRendimientoHoraTrabajador);
                string valoresAntiguos = JsonConvert.SerializeObject(rendimientoHoraTrabajador);
                if (rendimientoHoraTrabajador != null)
                {
                    db.Entry(rendimientoHoraTrabajador).CurrentValues.SetValues(actualizarRendimientoHoraTrabajador);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = rendimientoHoraTrabajador.IdRendimientoHoraTrabajador;
                    respuesta.Mensaje = "Se modificó los datos correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Actualizar",
                        NombreTabla = "RendimientoHoraTrabajador",
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = JsonConvert.SerializeObject(actualizarRendimientoHoraTrabajador),
                        IdUsuario = actualizarRendimientoHoraTrabajador.IdUsuarioModificacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El campo solicitado no existe.";
                }

                return respuesta;
            }
        }

        public List<RendimientoHoraTrabajadorGeneral> ListarRendimientoHoraTrabajador(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.RendimientoHoraTrabajador.Where(x => Id == null || x.IdRendimientoHoraTrabajador == Id)
                                                   .ToList()
                                                   .Select(x => Mapper.Map<RendimientoHoraTrabajadorGeneral>(x))
                                                   .ToList();
            }
        }
    }
}
