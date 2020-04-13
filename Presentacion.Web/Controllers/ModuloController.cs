using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Modulo;
using Servicios.Interfaces.Modulo.Peticiones;
using Servicios.Interfaces.Modulo.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class ModuloController : ApiController
    {
        IGestorDeModulos _gestorDeModulos;

        public ModuloController(IGestorDeModulos gestorDeModulos)
        {
            this._gestorDeModulos = gestorDeModulos;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Crear(NuevoModulo peticionDeCreacion)
        {
            return _gestorDeModulos.Crear(peticionDeCreacion);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<ModuloGeneral> Listar(int? Id)
        {
            return _gestorDeModulos.Listar(Id);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Actualizar(ActualizarModulo peticionDeActualizacion)
        {
            return _gestorDeModulos.Actualizar(peticionDeActualizacion);
        }
    }
}
