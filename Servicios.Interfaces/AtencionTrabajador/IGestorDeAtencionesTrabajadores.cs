using Dominio.Entidades.Compartido;
using Servicios.Interfaces.AtencionTrabajador.Peticiones;
using Servicios.Interfaces.AtencionTrabajador.Respuestas;
using System.Collections.Generic;

namespace Servicios.Interfaces.AtencionTrabajador
{
    public interface IGestorDeAtencionesTrabajadores
    {
        RespuestaBD RegistrarAtencionTrabajador(NuevaAtencionTrabajador nuevaAtencionTrabajador);
        List<AtencionTrabajadorGeneral> ListarAtencionTrabajador(int? Id);
    }
}
