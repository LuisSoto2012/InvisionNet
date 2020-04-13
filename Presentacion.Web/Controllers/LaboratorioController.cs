using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class LaboratorioController : ApiController
    {
        IGestorDeTomaMuestra _gestorDeTomaMuestra;

        public LaboratorioController(IGestorDeTomaMuestra gestorDeTomaMuestra)
        {
            this._gestorDeTomaMuestra = gestorDeTomaMuestra;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarIncidentesPacientes(NuevoIncidentesPacientes nuevoIncidentesPacientes)
        {
            return _gestorDeTomaMuestra.AgregarIncidentesPacientes(nuevoIncidentesPacientes);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarIncumplimientoAnalisis(NuevoIncumplimientoAnalisis nuevoIncumplimientoAnalisis)
        {
            return _gestorDeTomaMuestra.AgregarIncumplimientoAnalisis(nuevoIncumplimientoAnalisis);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarPruebasNoRealizadas(NuevoPruebasNoRealizadas nuevoPruebasNoRealizadas)
        {
            return _gestorDeTomaMuestra.AgregarPruebasNoRealizadas(nuevoPruebasNoRealizadas);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarRecoleccionMuestra(NuevoRecoleccionMuestra nuevoRecoleccionMuestra)
        {
            return _gestorDeTomaMuestra.AgregarRecoleccionMuestra(nuevoRecoleccionMuestra);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarVenopunturasFallidas(NuevoVenopunturasFallidas nuevoVenopunturasFallidas)
        {
            return _gestorDeTomaMuestra.AgregarVenopunturasFallidas(nuevoVenopunturasFallidas);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarIncidentesPacientes(ActualizarIncidentesPacientes actualizarIncidentesPacientes)
        {
            return _gestorDeTomaMuestra.EditarIncidentesPacientes(actualizarIncidentesPacientes);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarIncumplimientoAnalisis(ActualizarIncumplimientoAnalisis actualizarIncumplimientoAnalisis)
        {
            return _gestorDeTomaMuestra.EditarIncumplimientoAnalisis(actualizarIncumplimientoAnalisis);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarPruebasNoRealizadas(ActualizarPruebasNoRealizadas actualizarPruebasNoRealizadas)
        {
            return _gestorDeTomaMuestra.EditarPruebasNoRealizadas(actualizarPruebasNoRealizadas);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarRecoleccionMuestra(ActualizarRecoleccionMuestra actualizarRecoleccionMuestra)
        {
            return _gestorDeTomaMuestra.EditarRecoleccionMuestra(actualizarRecoleccionMuestra);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarVenopunturasFallidas(ActualizarVenopunturasFallidas actualizarVenopunturasFallidas)
        {
            return _gestorDeTomaMuestra.EditarVenopunturasFallidas(actualizarVenopunturasFallidas);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<IncidentesPacientesGeneral> ListarIncidentesPacientes(int? Id)
        {
            return _gestorDeTomaMuestra.ListarIncidentesPacientes(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<IncumplimientoAnalisisGeneral> ListarIncumplimientoAnalisis(int? Id)
        {
            return _gestorDeTomaMuestra.ListarIncumplimientoAnalisis(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<PruebasNoRealizadasGeneral> ListarPruebasNoRealizadas(int? Id)
        {
            return _gestorDeTomaMuestra.ListarPruebasNoRealizadas(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<RecoleccionMuestraGeneral> ListarRecoleccionMuestra(int? Id)
        {
            return _gestorDeTomaMuestra.ListarRecoleccionMuestra(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<VenopunturasFallidasGeneral> ListarVenopunturasFallidas(int? Id)
        {
            return _gestorDeTomaMuestra.ListarVenopunturasFallidas(Id);
        }
    }
}
