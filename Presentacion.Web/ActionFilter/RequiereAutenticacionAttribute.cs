﻿using JWT;
using Newtonsoft.Json;
using Servicios.Implementacion.Seguridad;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Usuario.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Presentacion.Web.ActionFilter
{
    public class RequiereAutenticacionAttribute: ActionFilterAttribute
    {
        private readonly IGestorDeToken _gestorDeToken = new GestorDeToken();

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string token = sacarTokenDeLaCabezera(actionContext);
            this.setUserIdentityFromToken(token, actionContext);
            base.OnActionExecuting(actionContext);
        }

        private void setUserIdentityFromToken(string tokenString, HttpActionContext actionContext)
        {
            try
            {
                UsuarioLogin usuario = this._gestorDeToken.RecuperarInformacionDeUsuario(tokenString);
                usuario.GuardarEnHttpContext(actionContext);
            }
            catch (TokenExpiredException)
            {
                actionContext.Response = GenenerarRespuestaNoAutorizada(actionContext, "El Token ha expirado");
            }
            catch (SignatureVerificationException)
            {
                actionContext.Response = GenenerarRespuestaNoAutorizada(actionContext, "El Token es invalido");
            }
            catch (JsonReaderException)
            {
                actionContext.Response = GenenerarRespuestaNoAutorizada(actionContext, "La firma no es valida para los datos");
            }
            catch (FormatException)
            {
                actionContext.Response = GenenerarRespuestaNoAutorizada(actionContext, "Token's signature is malformed");
            }
            catch (ArgumentException)
            {
                actionContext.Response = GenenerarRespuestaNoAutorizada(actionContext, "No cuenta con la cabecera de Autorizacion");
            }
        }


        private string sacarTokenDeLaCabezera(HttpActionContext filterContext)
        {
            IEnumerable<string> values;
            if (filterContext.Request.Headers.TryGetValues("Authorization", out values))
            {
                return values.First();
            }
            return null;
        }

        private HttpResponseMessage GenenerarRespuestaNoAutorizada(HttpActionContext actionContext, string message)
        {
            return actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized,new { Message = message });
        }
    }
}