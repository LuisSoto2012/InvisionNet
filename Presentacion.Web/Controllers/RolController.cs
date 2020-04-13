using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Seguridad.Rol;
using Servicios.Interfaces.Seguridad.Rol.Peticiones;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class RolController : ApiController
    {
        IGestorDeRoles _gestorDeRoles;

        public RolController(IGestorDeRoles gestorDeRoles)
        {
            this._gestorDeRoles = gestorDeRoles;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Crear(NuevoRol peticionDeCreacion)
        {
            return _gestorDeRoles.Crear(peticionDeCreacion);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<RolGeneral> Listar(int? Id)
        {
            return _gestorDeRoles.Listar(Id);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Actualizar(ActualizarRol peticionDeActualizacion)
        {
            return _gestorDeRoles.Actualizar(peticionDeActualizacion);
        }
    }
}
