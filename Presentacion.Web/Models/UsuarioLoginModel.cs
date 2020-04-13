using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Web.Models
{
    public class UsuarioLoginModel
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdAplicacion { get; set; }
    }
}