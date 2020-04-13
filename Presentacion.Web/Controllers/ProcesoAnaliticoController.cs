using Dominio.Entidades.Compartido;
using Presentacion.Web.ActionFilter;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class ProcesoAnaliticoController : ApiController
    {
        IGestorDeProcesoAnalitico _gestorDeProcesoAnalitico;

        public ProcesoAnaliticoController(IGestorDeProcesoAnalitico gestorDeProcesoAnalitico)
        {
            this._gestorDeProcesoAnalitico = gestorDeProcesoAnalitico;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarCalibracionDeficiente(NuevoCalibracionDeficiente nuevoCalibracionDeficiente)
        {
            return _gestorDeProcesoAnalitico.AgregarCalibracionDeficiente(nuevoCalibracionDeficiente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarEmpleoReactivo(NuevoEmpleoReactivo nuevoEmpleoReactivo)
        {
            return _gestorDeProcesoAnalitico.AgregarEmpleoReactivo(nuevoEmpleoReactivo);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarEquipoMalCalibrado(NuevoEquipoMalCalibrado nuevoEquipoMalCalibrado)
        {
            return _gestorDeProcesoAnalitico.AgregarEquipoMalCalibrado(nuevoEquipoMalCalibrado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarEquipoUPS(NuevoEquipoUPS nuevoEquipoUPS)
        {
            return _gestorDeProcesoAnalitico.AgregarEquipoUPS(nuevoEquipoUPS);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarMaterialNoCalibrado(NuevoMaterialNoCalibrado nuevoMaterialNoCalibrado)
        {
            return _gestorDeProcesoAnalitico.AgregarMaterialNoCalibrado(nuevoMaterialNoCalibrado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarMuestraHemolizadaLipemica(NuevoMuestraHemolizadaLipemica nuevoMuestraHemolizadaLipemica)
        {
            return _gestorDeProcesoAnalitico.AgregarMuestraHemolizadaLipemica(nuevoMuestraHemolizadaLipemica);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarPocoFrecuente(NuevoPocoFrecuente nuevoPocoFrecuente)
        {
            return _gestorDeProcesoAnalitico.AgregarPocoFrecuente(nuevoPocoFrecuente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD AgregarSueroMalReferenciado(NuevoSueroMalReferenciado nuevoSueroMalReferenciado)
        {
            return _gestorDeProcesoAnalitico.AgregarSueroMalReferenciado(nuevoSueroMalReferenciado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarCalibracionDeficiente(ActualizarCalibracionDeficiente actualizarCalibracionDeficiente)
        {
            return _gestorDeProcesoAnalitico.EditarCalibracionDeficiente(actualizarCalibracionDeficiente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarEmpleoReactivo(ActualizarEmpleoReactivo actualizarEmpleoReactivo)
        {
            return _gestorDeProcesoAnalitico.EditarEmpleoReactivo(actualizarEmpleoReactivo);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarEquipoMalCalibrado(ActualizarEquipoMalCalibrado actualizarEquipoMalCalibrado)
        {
            return _gestorDeProcesoAnalitico.EditarEquipoMalCalibrado(actualizarEquipoMalCalibrado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarEquipoUPS(ActualizarEquipoUPS actualizarEquipoUPS)
        {
            return _gestorDeProcesoAnalitico.EditarEquipoUPS(actualizarEquipoUPS);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarMaterialNoCalibrado(ActualizarMaterialNoCalibrado actualizarMaterialNoCalibrado)
        {
            return _gestorDeProcesoAnalitico.EditarMaterialNoCalibrado(actualizarMaterialNoCalibrado);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarMuestraHemolizadaLipemica(ActualizarMuestraHemolizadaLipemica actualizarMuestraHemolizadaLipemica)
        {
            return _gestorDeProcesoAnalitico.EditarMuestraHemolizadaLipemica(actualizarMuestraHemolizadaLipemica);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarPocoFrecuente(ActualizarPocoFrecuente actualizarPocoFrecuente)
        {
            return _gestorDeProcesoAnalitico.EditarPocoFrecuente(actualizarPocoFrecuente);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public RespuestaBD EditarSueroMalReferenciado(ActualizarSueroMalReferenciado actualizarSueroMalReferenciado)
        {
            return _gestorDeProcesoAnalitico.EditarSueroMalReferenciado(actualizarSueroMalReferenciado);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<CalibracionDeficienteGeneral> ListarCalibracionDeficiente(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarCalibracionDeficiente(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<EmpleoReactivoGeneral> ListarEmpleoReactivo(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarEmpleoReactivo(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<EquipoMalCalibradoGeneral> ListarEquipoMalCalibrado(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarEquipoMalCalibrado(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<EquipoUPSGeneral> ListarEquipoUPS(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarEquipoUPS(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<MaterialNoCalibradoGeneral> ListarMaterialNoCalibrado(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarMaterialNoCalibrado(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<MuestraHemolizadaLipemicaGeneral> ListarMuestraHemolizadaLipemica(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarMuestraHemolizadaLipemica(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<PocoFrecuenteGeneral> ListarPocoFrecuente(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarPocoFrecuente(Id);
        }

        [HttpGet]
        [RequiereAutenticacion]
        public List<SueroMalReferenciadoGeneral> ListarSueroMalReferenciado(int? Id)
        {
            return _gestorDeProcesoAnalitico.ListarSueroMalReferenciado(Id);
        }
    }
}
