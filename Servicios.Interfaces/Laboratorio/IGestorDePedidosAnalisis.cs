using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Laboratorio
{
    public interface IGestorDePedidosAnalisis
    {
        RespuestaBD AgregarTranscripcionErronea(NuevoTranscripcionErronea nuevoTranscripcionErronea);
        RespuestaBD AgregarSolicitudDatosIncompletos(NuevoSolicitudDatosIncompletos nuevoSolicitudDatosIncompletos);
        RespuestaBD EditarTranscripcionErronea(ActualizarTranscripcionErronea actualizarTranscripcionErronea);
        RespuestaBD EditarSolicitudDatosIncompletos(ActualizarSolicitudDatosIncompletos actualizarSolicitudDatosIncompletos);
        List<TranscripcionErroneaGeneral> ListarTranscripcionErronea(int? Id);
        List<SolicitudDatosIncompletosGeneral> ListarSolicitudDatosIncompletos(int? Id);
    }
}
