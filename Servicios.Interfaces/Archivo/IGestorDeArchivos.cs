using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Archivo.Peticiones;
using Servicios.Interfaces.Archivo.Respuestas;
using System.Collections.Generic;
using System.IO;

namespace Servicios.Interfaces.Archivo
{
    public interface IGestorDeArchivos
    {
        RespuestaBD Agregar(NuevoArchivo nuevoArchivo);
        List<ArchivoGeneral> Listar(ArchivoGeneral archivoGeneral);
        string Eliminar(int Id, int IdUsuario);
        List<ArchivoPorFechaYUsuario> ListarArchivoPorFechaYUsuario(ConsultarArchivoPor archivoPor);
        RespuestaBD ActualizarTemporales();
        RespuestaBD ActualizarNoTemporales();
    }
}
