using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Aplicacion;
using Servicios.Interfaces.Aplicacion.Peticiones;
using Servicios.Interfaces.Aplicacion.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class AplicacionController : ApiController
    {
        IGestorDeAplicaciones _gestorDeAplicaciones;

        public AplicacionController(IGestorDeAplicaciones gestorDeAplicaciones)
        {
            this._gestorDeAplicaciones = gestorDeAplicaciones;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Crear(NuevaAplicacion peticionDeCreacion)
        {
            return _gestorDeAplicaciones.Crear(peticionDeCreacion);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<AplicacionGeneral> Listar(int? Id)
        {
            return _gestorDeAplicaciones.Listar(Id);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD Actualizar(ActualizarAplicacion peticionDeActualizacion)
        {
            return _gestorDeAplicaciones.Actualizar(peticionDeActualizacion);
        }
    }
}
