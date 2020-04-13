using Dominio.Contexto;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Archivo;
using Servicios.Interfaces.Archivo.Peticiones;
using Servicios.Interfaces.Archivo.Respuestas;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class RepositorioArchivosController : ApiController
    {
        IGestorDeArchivos _gestorDeArchivos;

        public RepositorioArchivosController(IGestorDeArchivos gestorDeArchivos)
        {
            this._gestorDeArchivos = gestorDeArchivos;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD SubirArchivos()
        {
            HttpRequest httpRequest = HttpContext.Current.Request;
            RespuestaBD respuesta = new RespuestaBD();

            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    HttpPostedFile postedFile = httpRequest.Files[file];
                    string rutaDeRepositorio = string.Concat(System.Configuration.ConfigurationManager.AppSettings["RutaDeRepositorio"].ToString(), httpRequest.Params["HistoriaClinica"], "\\");
                    if (!Directory.Exists(rutaDeRepositorio)) Directory.CreateDirectory(rutaDeRepositorio);
                    string rutaCompleta = string.Concat(rutaDeRepositorio, postedFile.FileName);
                    postedFile.SaveAs(rutaCompleta);

                    NuevoArchivo nuevoArchivo = new NuevoArchivo
                    {
                        TipoArchivo = httpRequest.Params["TipoArchivo"],
                        IdEspecialidad = int.Parse(httpRequest.Params["IdEspecialidad"]),
                        IdServicio = int.Parse(httpRequest.Params["IdServicio"]),
                        HistoriaClinica = httpRequest.Params["HistoriaClinica"],
                        Ruta = rutaDeRepositorio,
                        NombreArchivo = postedFile.FileName,
                        RutaCompleta = rutaCompleta,
                        IdUsuarioCreacion = int.Parse(httpRequest.Params["IdUsuarioCreacion"])
                    };

                    respuesta = _gestorDeArchivos.Agregar(nuevoArchivo);
                }
            }
            else
            {
                // NO SE ENCONTRARON ARCHIVOS
                respuesta.Id = 0;
                respuesta.Mensaje = "No se seleccionaron archivos para subir.";
            }

            return respuesta;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<ArchivoGeneral> ListarArchivos(ArchivoGeneral archivoGeneral)
        {
            return _gestorDeArchivos.Listar(archivoGeneral);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public RespuestaBD Eliminar(int Id, int IdUsuario)
        {
            RespuestaBD respuesta = new RespuestaBD();
            string archivoEliminado = _gestorDeArchivos.Eliminar(Id, IdUsuario);
            if (archivoEliminado != "")
            {
                File.Delete(archivoEliminado);
                respuesta.Id = 1;
                respuesta.Mensaje = "El archivo fue eliminado del repositorio correctamente.";
            }
            else
            {
                respuesta.Id = 0;
                respuesta.Mensaje = "No se envontró ningún archivo para eliminar.";
            }
            return respuesta;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<ArchivoPorFechaYUsuario> ListarArchivoPorFechaYUsuario(ConsultarArchivoPor archivoPor)
        {
            return _gestorDeArchivos.ListarArchivoPorFechaYUsuario(archivoPor);
        }

        [HttpGet]
        public RespuestaBD Abc()
        {
            RespuestaBD respuesta = new RespuestaBD();

            using (InoBD db = new InoBD())
            using (GalenPlusBD dbGalen = new GalenPlusBD())
            {
                var archList = db.Archivos.ToList();

                DirectoryInfo directory = new DirectoryInfo(@"\\\\192.168.0.11\\RepositorioArchivosInvision\\RepositorioArchivos\\");

                foreach (var arch in archList)
                {
                    var hc = int.Parse(arch.HistoriaClinica);
                    if (hc < 25330)
                    {
                        DirectoryInfo folder = directory.GetDirectories().Where(x => x.Name == arch.HistoriaClinica).FirstOrDefault();
                        if (folder != null)
                        {
                            var dni = dbGalen.Database.SqlQuery<string>("dbo.Invision_ObtenerDniPorHC @HC, @TN",
                            new SqlParameter("HC", folder.Name),
                            new SqlParameter("TN", 5)).FirstOrDefault();
                            if (dni != null)
                            {
                                Directory.Move(folder.FullName, folder.Parent.FullName + "\\" + dni);
                            }
                                
                        }
                    }
                }


            }
            respuesta.Id = 1;
            respuesta.Mensaje = "Actualizcion Directorios Temporales";
            return respuesta;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public RespuestaBD ActualizarTemporales()
        {
            return _gestorDeArchivos.ActualizarTemporales();
        }
    }
}
