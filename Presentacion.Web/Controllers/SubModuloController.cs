using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.SubModulo;
using Servicios.Interfaces.SubModulo.Peticiones;
using Servicios.Interfaces.SubModulo.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class SubModuloController : ApiController
    {
        IGestorDeSubModulos _gestorDeSubModulos;

        public SubModuloController(IGestorDeSubModulos gestorDeSubModulos)
        {
            this._gestorDeSubModulos = gestorDeSubModulos;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Crear(NuevoSubModulo peticionDeCreacion)
        {
            return _gestorDeSubModulos.Crear(peticionDeCreacion);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<SubModuloGeneral> Listar(int? Id)
        {
            return _gestorDeSubModulos.Listar(Id);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Actualizar(ActualizarSubModulo peticionDeActualizacion)
        {
            return _gestorDeSubModulos.Actualizar(peticionDeActualizacion);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AsignarRolSubModulo(RolSubModuloDto rolSubModuloDto)
        {
            return _gestorDeSubModulos.AsignarRolSubModulo(rolSubModuloDto);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<RolSubModuloDto> ObtenerRolSubModulo(RolSubModuloDto rolSubModuloDto)
        {
            return _gestorDeSubModulos.ObtenerRolSubModulo(rolSubModuloDto);
        }
    }
}
