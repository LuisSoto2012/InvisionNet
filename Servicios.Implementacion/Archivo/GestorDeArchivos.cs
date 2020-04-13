using AutoMapper;
using Dominio.Contexto;
using Dominio.Entidades.Compartido;
using Newtonsoft.Json;
using Servicios.Implementacion.Auditoria;
using Servicios.Interfaces.Archivo;
using Servicios.Interfaces.Archivo.Peticiones;
using Servicios.Interfaces.Archivo.Respuestas;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Servicios.Implementacion.Archivo
{
    public class GestorDeArchivos : IGestorDeArchivos
    {
        RespuestaBD respuesta = new RespuestaBD();
        IGestorDeAuditoria _gestorDeAuditoria = new GestorDeAuditoria();

        public RespuestaBD ActualizarNoTemporales()
        {
            using (InoBD db = new InoBD())
            using (GalenPlusBD dbGalen = new GalenPlusBD())
            {
                var archList = db.Archivos.ToList();

                DirectoryInfo directory = new DirectoryInfo(@"\\\\192.168.0.11\\RepositorioArchivosInvision\\RepositorioArchivos\\");

                foreach (var arch in archList)
                {
                    if (int.Parse(arch.HistoriaClinica) > 25330)
                    {
                        DirectoryInfo folder = directory.GetDirectories().Where(x => x.Name == arch.HistoriaClinica).FirstOrDefault();
                        if (folder != null)
                        {
                            var dni = dbGalen.Database.SqlQuery<NroDocumentoPorHC>("dbo.Invision_ObtenerDniPorHC @HC, @TN",
                            new SqlParameter("HC", folder.Name),
                            new SqlParameter("TN", 4)).FirstOrDefault();
                            if (dni != null)
                                Directory.Move(folder.FullName, folder.Parent.FullName + "\\" + dni.NroDocumento);
                        }
                    }
                }

               
            }
            respuesta.Id = 1;
            respuesta.Mensaje = "Actualizcion Directorios Temporales";
            return respuesta;
        }

        public RespuestaBD ActualizarTemporales()
        {
            using (InoBD db = new InoBD())
            using (GalenPlusBD dbGalen = new GalenPlusBD())
            {
                var archList = db.Archivos.ToList();

                DirectoryInfo directory = new DirectoryInfo(@"\\\\192.168.0.11\\RepositorioArchivosInvision\\RepositorioArchivos\\");

                foreach (var arch in archList)
                {
                    if (int.Parse(arch.HistoriaClinica) <= 25330)
                    {
                        DirectoryInfo folder = directory.GetDirectories().Where(x => x.Name == arch.HistoriaClinica).FirstOrDefault();
                        if (folder != null)
                        {
                            var dni = dbGalen.Database.SqlQuery<NroDocumentoPorHC>("dbo.Invision_ObtenerDniPorHC @HC, @TN",
                            new SqlParameter("HC", folder.Name),
                            new SqlParameter("TN", 4)).FirstOrDefault();
                            if (dni != null)
                                Directory.Move(folder.FullName, folder.Parent.FullName + "\\" + dni.NroDocumento);
                        }
                    }
                }
            }
            respuesta.Id = 1;
            respuesta.Mensaje = "Actualizcion Directorios No Temporales";
            return respuesta;
        }

        public RespuestaBD Agregar(NuevoArchivo nuevoArchivo)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Archivo archivo = Mapper.Map<Dominio.Entidades.Archivo>(nuevoArchivo);
                Dominio.Entidades.Archivo archivoEncontrado = db.Archivos.Where(x => x.IdEspecialidad == nuevoArchivo.IdEspecialidad && x.IdServicio == nuevoArchivo.IdServicio && x.HistoriaClinica == nuevoArchivo.HistoriaClinica && x.NombreArchivo == nuevoArchivo.NombreArchivo).FirstOrDefault();
                if (archivoEncontrado == null)
                {
                    db.Archivos.Add(archivo);
                    db.SaveChanges();
                    //Mensaje de respuesta
                    respuesta.Id = archivo.IdArchivo;
                    respuesta.Mensaje = "Se subió el archivo correctamente.";
                }
                else
                {
                    //Mensaje de respuesta
                    respuesta.Id = 1;
                    respuesta.Mensaje = "Se subió el archivo correctamente.";
                }

                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Agregar",
                    NombreTabla = "Archivo",
                    ValoresAntiguos = null,
                    ValoresNuevos = JsonConvert.SerializeObject(nuevoArchivo),
                    IdUsuario = nuevoArchivo.IdUsuarioCreacion
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return respuesta;
            }
        }

        public string Eliminar(int Id, int IdUsuario)
        {
            using (InoBD db = new InoBD())
            {
                string rutaCompleta = "";
                Dominio.Entidades.Archivo archivo = db.Archivos.Find(Id);
                string valoresAntiguos = JsonConvert.SerializeObject(archivo);
                if (archivo != null)
                {
                    db.Archivos.Remove(archivo);
                    rutaCompleta = archivo.RutaCompleta;
                    db.SaveChanges();
                }
                // Auditoria
                AuditoriaGeneral auditoria = new AuditoriaGeneral
                {
                    Accion = "Eliminar",
                    NombreTabla = "Archivo",
                    ValoresAntiguos = valoresAntiguos,
                    ValoresNuevos = null,
                    IdUsuario = IdUsuario
                };
                this._gestorDeAuditoria.AgregarAuditoria(auditoria);

                return rutaCompleta;
            }
        }

        public List<ArchivoGeneral> Listar(ArchivoGeneral archivoGeneral)
        {
            using (InoBD db = new InoBD())
            {
                var query = (from a in db.Archivos
                             where ((a.HistoriaClinica == archivoGeneral.HistoriaClinica) || (a.NroDocumento == archivoGeneral.NroDocumento))&&
                                   (archivoGeneral.IdServicio == 0 || a.IdServicio == archivoGeneral.IdServicio) &&
                                   (archivoGeneral.TipoArchivo == "" || a.TipoArchivo == archivoGeneral.TipoArchivo) &&
                                   (a.EsActivo == true)
                                   select new
                                   {
                                       IdArchivo = (archivoGeneral.IdServicio == 0 && archivoGeneral.TipoArchivo == "jpg") ? 0 : a.IdArchivo,
                                       TipoArchivo = a.TipoArchivo,
                                       IdServicio = a.IdServicio,
                                       HistoriaClinica = a.HistoriaClinica,
                                       NombreArchivo = (archivoGeneral.IdServicio == 0 && archivoGeneral.TipoArchivo == "jpg") ? string.Empty : a.NombreArchivo,
                                       RutaCompleta = (archivoGeneral.IdServicio == 0 && archivoGeneral.TipoArchivo == "jpg") ? string.Empty : a.RutaCompleta,
                                       EsActivo = (archivoGeneral.IdServicio == 0 && archivoGeneral.TipoArchivo == "jpg") ? true : a.EsActivo,
                                       FechaCreacion = (archivoGeneral.IdServicio == 0 && archivoGeneral.TipoArchivo == "jpg") ? DateTime.Now : a.FechaCreacion
                                   }
                            ).Distinct().OrderByDescending(x => x.FechaCreacion).ToList();
                return query.Select(x => new ArchivoGeneral
                {
                    IdArchivo = x.IdArchivo,
                    TipoArchivo = x.TipoArchivo,
                    IdServicio = x.IdServicio,
                    HistoriaClinica = x.HistoriaClinica,
                    NombreArchivo = x.NombreArchivo,
                    ArchivoBinario = (string.IsNullOrEmpty(x.RutaCompleta)) ? string.Empty : Convert.ToBase64String(File.ReadAllBytes(x.RutaCompleta)),
                    EsActivo = x.EsActivo,
                    Fecha = x.FechaCreacion.ToString("dd/MM/yyyy")
                }).ToList();
            }
        }

        public List<ArchivoPorFechaYUsuario> ListarArchivoPorFechaYUsuario(ConsultarArchivoPor archivoPor)
        {
            using (InoBD db = new InoBD())
            {
                return db.Database.SqlQuery<ArchivoPorFechaYUsuario>("dbo.Invision_MonitoreoReferencia @FechaDesde, @FechaHasta, @IdEmpleado, @Usuario",
                            new SqlParameter("FechaDesde", archivoPor.FechaDesde),
                            new SqlParameter("FechaHasta", archivoPor.FechaHasta),
                            new SqlParameter("IdEmpleado", archivoPor.IdUsuario),
                            new SqlParameter("Usuario", "Usuario")
                        ).ToList()
                        .Select(x => new ArchivoPorFechaYUsuario {
                            Fecha = x.Fecha,
                            NombreArchivo = x.NombreArchivo,
                            Usuario = x.Usuario,
                            Conteo = x.Conteo,
                            ArchivoBinario = (string.IsNullOrEmpty(x.RutaCompleta)) ? string.Empty : Convert.ToBase64String(File.ReadAllBytes(x.RutaCompleta))
                        }).ToList();
            }
        }
    }
}
