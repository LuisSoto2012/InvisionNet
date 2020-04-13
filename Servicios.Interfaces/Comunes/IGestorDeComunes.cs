using System.Collections.Generic;

namespace Servicios.Interfaces.Comunes
{
    public interface IGestorDeComunes
    {
        List<ComboBox> ListarCondicionTrabajo();
        List<ComboBox> ListarTipoEmpleado();
        List<ComboBox> ListarTipoDocumentoIdentidad();
        List<ComboBox> ListarAreaLaboratorio(int? Id);
        List<ComboBox> ListarPruebaLabotario(string Codigo);
        List<ComboBox> ListarServicioEspecialidad(int? Id);
        List<ComboBox> ListarEspecialidades();
        List<ComboBox> ListarUsuarioPorRol(int? Id);
        List<ComboBox> ListarAlmacenes();
        List<ComboBox> ListarEscalafonDeLegajos();
        ComboBox ListarRespuestaIndicadoresDesempeno(string codigo);
        List<ComboBox> ListarCajeros();
    }
}
