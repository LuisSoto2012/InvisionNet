using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Laboratorio
{
    public interface IGestorDeTomaMuestra
    {
        RespuestaBD AgregarRecoleccionMuestra(NuevoRecoleccionMuestra nuevoRecoleccionMuestra);
        RespuestaBD AgregarVenopunturasFallidas(NuevoVenopunturasFallidas nuevoVenopunturasFallidas);
        RespuestaBD AgregarIncidentesPacientes(NuevoIncidentesPacientes nuevoIncidentesPacientes);
        RespuestaBD AgregarIncumplimientoAnalisis(NuevoIncumplimientoAnalisis nuevoIncumplimientoAnalisis);
        RespuestaBD AgregarPruebasNoRealizadas(NuevoPruebasNoRealizadas nuevoPruebasNoRealizadas);
        RespuestaBD EditarRecoleccionMuestra(ActualizarRecoleccionMuestra actualizarRecoleccionMuestra);
        RespuestaBD EditarVenopunturasFallidas(ActualizarVenopunturasFallidas actualizarVenopunturasFallidas);
        RespuestaBD EditarIncidentesPacientes(ActualizarIncidentesPacientes actualizarIncidentesPacientes);
        RespuestaBD EditarIncumplimientoAnalisis(ActualizarIncumplimientoAnalisis actualizarIncumplimientoAnalisis);
        RespuestaBD EditarPruebasNoRealizadas(ActualizarPruebasNoRealizadas actualizarPruebasNoRealizadas);
        List<RecoleccionMuestraGeneral> ListarRecoleccionMuestra(int? Id);
        List<VenopunturasFallidasGeneral> ListarVenopunturasFallidas(int? Id);
        List<IncidentesPacientesGeneral> ListarIncidentesPacientes(int? Id);
        List<IncumplimientoAnalisisGeneral> ListarIncumplimientoAnalisis(int? Id);
        List<PruebasNoRealizadasGeneral> ListarPruebasNoRealizadas(int? Id);
    }
}
