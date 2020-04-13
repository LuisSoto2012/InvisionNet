using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Congreso.Peticiones;
using Servicios.Interfaces.Congreso.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Congreso
{
    public interface IGestorDeCongreso
    {
        List<AsistenciaGeneral> EventoAsistenciaListar(int IdHorario, int IdEvento);
        RespuestaBD EventoAsistenciaRegistrar(NuevaAsistencia nuevaAsistencia);
        List<EventoGeneral> EventoListar();
        ParticipanteGeneral EventoParticipanteXDNI(string NumeroDocumento);
    }
}
