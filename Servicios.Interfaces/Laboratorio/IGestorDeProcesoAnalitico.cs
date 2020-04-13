using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Laboratorio
{
    public interface IGestorDeProcesoAnalitico
    {
        RespuestaBD AgregarPocoFrecuente(NuevoPocoFrecuente nuevoPocoFrecuente);
        RespuestaBD AgregarEmpleoReactivo(NuevoEmpleoReactivo nuevoEmpleoReactivo);
        RespuestaBD AgregarEquipoMalCalibrado(NuevoEquipoMalCalibrado nuevoEquipoMalCalibrado);
        RespuestaBD AgregarEquipoUPS(NuevoEquipoUPS nuevoEquipoUPS);
        RespuestaBD AgregarCalibracionDeficiente(NuevoCalibracionDeficiente nuevoCalibracionDeficiente);
        RespuestaBD AgregarSueroMalReferenciado(NuevoSueroMalReferenciado nuevoSueroMalReferenciado);
        RespuestaBD AgregarMaterialNoCalibrado(NuevoMaterialNoCalibrado nuevoMaterialNoCalibrado);
        RespuestaBD AgregarMuestraHemolizadaLipemica(NuevoMuestraHemolizadaLipemica nuevoMuestraHemolizadaLipemica);
        RespuestaBD EditarPocoFrecuente(ActualizarPocoFrecuente actualizarPocoFrecuente);
        RespuestaBD EditarEmpleoReactivo(ActualizarEmpleoReactivo actualizarEmpleoReactivo);
        RespuestaBD EditarEquipoMalCalibrado(ActualizarEquipoMalCalibrado actualizarEquipoMalCalibrado);
        RespuestaBD EditarEquipoUPS(ActualizarEquipoUPS actualizarEquipoUPS);
        RespuestaBD EditarCalibracionDeficiente(ActualizarCalibracionDeficiente actualizarCalibracionDeficiente);
        RespuestaBD EditarSueroMalReferenciado(ActualizarSueroMalReferenciado actualizarSueroMalReferenciado);
        RespuestaBD EditarMaterialNoCalibrado(ActualizarMaterialNoCalibrado actualizarMaterialNoCalibrado);
        RespuestaBD EditarMuestraHemolizadaLipemica(ActualizarMuestraHemolizadaLipemica actualizarMuestraHemolizadaLipemica);
        List<PocoFrecuenteGeneral> ListarPocoFrecuente(int? Id);
        List<EmpleoReactivoGeneral> ListarEmpleoReactivo(int? Id);
        List<EquipoMalCalibradoGeneral> ListarEquipoMalCalibrado(int? Id);
        List<EquipoUPSGeneral> ListarEquipoUPS(int? Id);
        List<CalibracionDeficienteGeneral> ListarCalibracionDeficiente(int? Id);
        List<SueroMalReferenciadoGeneral> ListarSueroMalReferenciado(int? Id);
        List<MaterialNoCalibradoGeneral> ListarMaterialNoCalibrado(int? Id);
        List<MuestraHemolizadaLipemicaGeneral> ListarMuestraHemolizadaLipemica(int? Id);
    }
}
