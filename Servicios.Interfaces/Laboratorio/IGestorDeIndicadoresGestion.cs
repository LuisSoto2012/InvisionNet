using Dominio.Entidades.Compartido;
using Servicios.Interfaces.Laboratorio.Peticiones;
using Servicios.Interfaces.Laboratorio.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.Laboratorio
{
    public interface IGestorDeIndicadoresGestion
    {
        RespuestaBD AgregarRendimientoHoraTrabajador(NuevoRendimientoHoraTrabajador nuevoRendimientoHoraTrabajador);
        RespuestaBD EditarRendimientoHoraTrabajador(ActualizarRendimientoHoraTrabajador actualizarRendimientoHoraTrabajador);
        List<RendimientoHoraTrabajadorGeneral> ListarRendimientoHoraTrabajador(int? Id);
    }
}
