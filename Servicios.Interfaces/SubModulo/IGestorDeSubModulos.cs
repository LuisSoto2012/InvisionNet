using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.SubModulo.Peticiones;
using Servicios.Interfaces.SubModulo.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.SubModulo
{
    public interface IGestorDeSubModulos : IMantenimientoBasico<NuevoSubModulo, ActualizarSubModulo, SubModuloGeneral>
    {
        RespuestaBD AsignarRolSubModulo(RolSubModuloDto rolSubModuloDto);
        List<RolSubModuloDto> ObtenerRolSubModulo(RolSubModuloDto rolSubModuloDto);
    }
}
