using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Laboratorio
{
    public interface IGestorDeTranscripcionResultados
    {
        RespuestaBD AgregarTranscripcionErroneaInoportuna(NuevoTranscripcionErroneaInoportuna nuevoTranscripcionErroneaInoportuna);
        RespuestaBD EditarTranscripcionErroneaInoportuna(ActualizarTranscripcionErroneaInoportuna actualizarTranscripcionErroneaInoportuna);
        List<TranscripcionErroneaInoportunaGeneral> ListarTranscripcionErroneaInoportuna(int? Id);
        RespuestaBD AgregarPacienteSinResultado(NuevoPacienteSinResultado nuevoPacienteSinResultado);
        RespuestaBD EditarPacienteSinResultado(ActualizarPacienteSinResultado actualizarPacienteSinResultado);
        List<PacienteSinResultadoGeneral> ListarPacienteSinResultado(int? Id);
    }
}
