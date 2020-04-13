using Newtonsoft.Json;
using Presentacion.Web.ActionFilter;
using Presentacion.Web.Models;
using Servicios.Interfaces.BonoDesempeno;
using Servicios.Interfaces.BonoDesempeno.Peticiones;
using Servicios.Interfaces.BonoDesempeno.Repuestas;
using Servicios.Interfaces.Comunes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Presentacion.Web.Controllers
{
    public class BonoDesempenoController : ApiController
    {
        IGestorDeBonoDesempeno _gestorDeBonoDesempeno;
        IGestorDeComunes _gestorDeComunes;

        public BonoDesempenoController(IGestorDeBonoDesempeno gestorDeBonoDesempeno, IGestorDeComunes gestorDeComunes)
        {
            this._gestorDeBonoDesempeno = gestorDeBonoDesempeno;
            this._gestorDeComunes = gestorDeComunes;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public async Task<List<TramasNoValidas>> EnviarTramaDiferimientoCitas(DatosTramaBono datosTramaBono)
        {
            TokenResponse tokenResponse = await ObtenerToken(); 
            List<FormatoTrama> listaDiferimientoCitas = _gestorDeBonoDesempeno.ListarDiferimientoCitas(datosTramaBono);
            List<TramasNoValidas> tramasNoValidas = new List<TramasNoValidas>();
            foreach (FormatoTrama diferimiento in listaDiferimientoCitas)
            {
                RespuestaTrama respuestaTrama = await RegistrarTrama(tokenResponse, diferimiento);
                if(respuestaTrama.codigo_respuesta != "0000")
                {
                    ComboBox codigoRepuesta = _gestorDeComunes.ListarRespuestaIndicadoresDesempeno(respuestaTrama.codigo_respuesta);
                    tramasNoValidas.Add( new TramasNoValidas {
                        IdCita = diferimiento.id_cita,
                        MensajeError = codigoRepuesta.Descripcion,
                        FormatoTrama = diferimiento
                    });
                }
            }
            return tramasNoValidas;
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<TiempoEsperaAtencion> ListarTiempoEsperaAtencion(DatosTramaBono datosTramaBono)
        {
            return _gestorDeBonoDesempeno.ListarTiempoEsperaAtencion(datosTramaBono);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<FormatoTrama> ListarDiferimientoCitas(DatosTramaBono datosTramaBono)
        {
            return _gestorDeBonoDesempeno.ListarDiferimientoCitas(datosTramaBono);
        }

        [HttpPost]
        [RequiereAutenticacion]
        public List<FormatoTramaConDias> ListarDiferimientoCitasConDias(DatosTramaBono datosTramaBono)
        {
            return _gestorDeBonoDesempeno.ListarDiferimientoCitasConDias(datosTramaBono);
        }

        private async Task<TokenResponse> ObtenerToken()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            using (HttpClient client = new HttpClient())
            {
                String urlToken = ConfigurationManager.AppSettings["UrlToken"].ToString();
                String username = ConfigurationManager.AppSettings["Username"].ToString();
                String password = ConfigurationManager.AppSettings["Password"].ToString();
                String authorization = ConfigurationManager.AppSettings["Authorization"].ToString();

                client.BaseAddress = new Uri(urlToken);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorization);
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("grant_type", "password")
                });
                var result = await client.PostAsync("/token", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TokenResponse>(resultContent);
            }
        }

        private async Task<RespuestaTrama> RegistrarTrama(TokenResponse tokenResponse, FormatoTrama diferimiento)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            using (var client = new HttpClient())
            {
                String urlRegistro = ConfigurationManager.AppSettings["UrlRegistro"].ToString();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenResponse.token_type, tokenResponse.access_token);
                using (var request = new HttpRequestMessage(HttpMethod.Post, urlRegistro))
                {
                    var json = JsonConvert.SerializeObject(diferimiento);
                    using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                    {
                        request.Content = stringContent;

                        using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                        {
                            string resultContent = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject<RespuestaTrama>(resultContent);
                        }
                    }
                }
            }
        }
    }
}
