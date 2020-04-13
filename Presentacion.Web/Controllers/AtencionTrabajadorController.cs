using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.AtencionTrabajador;
using Servicios.Interfaces.AtencionTrabajador.Peticiones;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class AtencionTrabajadorController : ApiController
    {
        IGestorDeAtencionesTrabajadores _gestorDeAtencionesTrabajadores;

        public AtencionTrabajadorController(IGestorDeAtencionesTrabajadores gestorDeAtencionesTrabajadores)
        {
            this._gestorDeAtencionesTrabajadores = gestorDeAtencionesTrabajadores;
        }

        [HttpPost]
        //[RequiereAutenticacion]
        public RespuestaBD RegistrarAtencionTrabajador(NuevaAtencionTrabajador nuevaAtencionTrabajador)
        {
            return _gestorDeAtencionesTrabajadores.RegistrarAtencionTrabajador(nuevaAtencionTrabajador);
        }
    }
}
