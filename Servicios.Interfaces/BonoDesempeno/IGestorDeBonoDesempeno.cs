using Servicios.Interfaces.BonoDesempeno.Peticiones;
using Servicios.Interfaces.BonoDesempeno.Repuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.BonoDesempeno
{
    public interface IGestorDeBonoDesempeno
    {
            List<FormatoTrama> ListarDiferimientoCitas(DatosTramaBono datosTramaBono);
            List<FormatoTramaConDias> ListarDiferimientoCitasConDias(DatosTramaBono datosTramaBono);
            List<TiempoEsperaAtencion> ListarTiempoEsperaAtencion(DatosTramaBono datosTramaBono);
    }
}
