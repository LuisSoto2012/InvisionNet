using Dominio.Entidades.Compartido;
using System.Collections.Generic;

namespace Servicios.Interfaces.Compartido
{
    public interface IMantenimientoBasico <TClaseDeCreacion, TClaseDeActualizacion, TClaseRespuestaGeneral>
    {
        RespuestaBD Crear(TClaseDeCreacion peticionDeCreacion);
        List<TClaseRespuestaGeneral> Listar(int? Id);
        RespuestaBD Actualizar (TClaseDeActualizacion peticionDeActualizacion);

    }
}
