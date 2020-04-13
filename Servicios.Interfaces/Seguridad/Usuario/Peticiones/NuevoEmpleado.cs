using Servicios.Interfaces.Aplicacion.Respuestas;
using Servicios.Interfaces.Comunes;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using System;
using System.Collections.Generic;

namespace Servicios.Interfaces.Usuario.Peticiones
{
    public class NuevoEmpleado
    {
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public ComboBox CondicionTrabajo { get; set; }
        public ComboBox TipoEmpleado { get; set; }
        public ComboBox TipoDocumentoIdentidad { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodigoPlanilla { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public List<RolGeneral> Roles { get; set; }
        public List<AplicacionGeneral> Aplicaciones { get; set; }
        public bool UsuarioGaleno { get; set; }
    }
}
