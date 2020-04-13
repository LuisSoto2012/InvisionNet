using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class EmpleadoController : ApiController
    {
        IGestorDeUsuarios _gestorDeUsuarios;

        public EmpleadoController(IGestorDeUsuarios gestorDeUsuarios)
        {
            this._gestorDeUsuarios = gestorDeUsuarios;
        }
        
        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Crear(NuevoEmpleado peticionDeCreacion)
        {
            return _gestorDeUsuarios.Crear(peticionDeCreacion);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<EmpleadoGeneral> Listar(int? Id)
        {
            return _gestorDeUsuarios.Listar(Id);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Actualizar(ActualizarEmpleado peticionDeActualizacion)
        {
            return _gestorDeUsuarios.Actualizar(peticionDeActualizacion);
        }
    }
}
