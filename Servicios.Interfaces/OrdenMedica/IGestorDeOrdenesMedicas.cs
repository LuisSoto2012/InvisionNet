using Dominio.Entidades.Compartido;
using Servicios.Interfaces.OrdenMedica.Peticiones;
using Servicios.Interfaces.OrdenMedica.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica
{
    public interface IGestorDeOrdenesMedicas
    {
        RespuestaBD AgregarOrdenMedica(NuevaOrdenMedica nuevaOrdenMedica);
        List<OrdenMedicaGeneral> ListarOrdenesMedicas(int? IdUsuario, int? IdOrdenMedica);
        List<TipoOrdenMedicaGeneral> ListarTipoOrdenMedica(int? Id);
    }
}
