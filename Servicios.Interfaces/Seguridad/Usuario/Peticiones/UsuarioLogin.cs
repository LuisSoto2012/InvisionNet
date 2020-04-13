using Servicios.Interfaces.Modulo.Respuestas;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Servicios.Interfaces.Usuario.Peticiones
{
    public class UsuarioLogin
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public List<RolGeneral> Roles { get; set; }
        public List<ModuloMenu> Modulo { get; set; }
        public bool LoginEstado { get; set; }
    }
}
