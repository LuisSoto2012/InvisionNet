using System.ComponentModel.DataAnnotations;
using Servicios.Interfaces.Seguridad.Rol.Respuestas;
using System.Collections.Generic;
using System;
using Servicios.Interfaces.Aplicacion.Respuestas;
using Servicios.Interfaces.Comunes;

namespace Servicios.Interfaces.Usuario.Respuestas
{
    public class EmpleadoGeneral
    {
        [Key]
        public int IdEmpleado { get; set; }
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
        public bool LoginEstado { get; set; }
        public string LoginIp { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsActivo { get; set; }
        public List<RolGeneral> Roles { get; set; }
        public List<AplicacionGeneral> Aplicaciones { get; set; }
    }
}
