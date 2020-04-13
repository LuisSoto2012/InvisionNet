using Servicios.Interfaces.Usuario.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace Presentacion.Web.ActionFilter
{
    public static class ExtensionDeUsuario
    {
        private static readonly string USER_DATA_KEY = "DatosDelUsuario";

        public static void GuardarEnHttpContext(this UsuarioLogin usuario, HttpActionContext actionContext)
        {
            actionContext.Request.Properties.Add(USER_DATA_KEY, usuario);
        }

        public static UsuarioLogin CargarUsuario(this HttpActionContext actionContext)
        {
            return (UsuarioLogin)actionContext.Request.Properties[USER_DATA_KEY];
        }
    }
}