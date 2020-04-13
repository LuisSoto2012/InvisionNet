using System.Collections.Generic;
using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Dominio.Entidades;
using Servicios.Interfaces.AtencionTrabajador;
using Servicios.Interfaces.AtencionTrabajador.Peticiones;
using Servicios.Interfaces.AtencionTrabajador.Respuestas;
using System.Linq;
using System;
using Servicios.Interfaces.Auditoria.Peticiones;
using Newtonsoft.Json;
using Servicios.Interfaces.Auditoria;
using Servicios.Implementacion.Auditoria;

namespace Servicios.Implementacion.AtencionTrabajor
{
    public class GestorDeAtencionesTrabajadores : IGestorDeAtencionesTrabajadores
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public List<AtencionTrabajadorGeneral> ListarAtencionTrabajador(int? Id)
        {
            using (InoBD db = new InoBD())
            {
                return db.AtencionTrabajador.Where(x => x.EsActivo == true &&
                                                  (Id == null || x.IdAtencionTrabajador == Id))
                                            .ToList()
                                            .Select(x => Mapper.Map<AtencionTrabajadorGeneral>(x))
                                            .ToList();
            }
        }

        public RespuestaBD RegistrarAtencionTrabajador(NuevaAtencionTrabajador nuevaAtencionTrabajador)
        {
            using (InoBD db = new InoBD())
            {
                AtencionTrabajador pacienteEncontrado = db.AtencionTrabajador.Where(x => x.FechaCreacion.Day == DateTime.Now.Day &&
                                                        x.FechaCreacion.Month == DateTime.Now.Month &&
                                                        x.FechaCreacion.Year == DateTime.Now.Year &&
                                                        x.HistoriaClinica == nuevaAtencionTrabajador.HistoriaClinica).FirstOrDefault();
                if (pacienteEncontrado == null)
                {
                    AtencionTrabajador atencionTrabajador = Mapper.Map<AtencionTrabajador>(nuevaAtencionTrabajador);
                    db.AtencionTrabajador.Add(atencionTrabajador);
                    db.SaveChanges();

                    foreach (var diagnostico in nuevaAtencionTrabajador.Diagnosticos)
                    {
                        AtencionTrabajador_Diagnostico atencion_Diagnostico = new AtencionTrabajador_Diagnostico
                        {
                            IdAtencionTrabajador = atencionTrabajador.IdAtencionTrabajador,
                            IdDiagnostico = diagnostico.Id,
                            TipoDiagnostico = diagnostico.Codigo,
                            IdUsuarioCreacion = nuevaAtencionTrabajador.IdUsuarioCreacion
                        };
                        db.AtencionTrabajador_Diagnostico.Add(atencion_Diagnostico);
                        db.SaveChanges();
                    }

                    //Mensaje de respuesta
                    respuesta.Id = atencionTrabajador.IdAtencionTrabajador;
                    respuesta.Mensaje = "Se guardó la atención correctamente.";

                    // Auditoria
                    AuditoriaGeneral auditoria = new AuditoriaGeneral
                    {
                        Accion = "Agregar",
                        NombreTabla = "AtencionTrabajador",
                        ValoresAntiguos = null,
                        ValoresNuevos = JsonConvert.SerializeObject(nuevaAtencionTrabajador),
                        IdUsuario = nuevaAtencionTrabajador.IdUsuarioCreacion
                    };
                    this._gestorDeAuditoria.AgregarAuditoria(auditoria);
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 0;
                    respuesta.Mensaje = "El paciente ya cuenta con un registro para el día de hoy, intente de nuevo.";
                }
            }
            return respuesta;
        }
    }
}
