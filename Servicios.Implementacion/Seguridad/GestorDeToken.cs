using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Usuario.Peticiones;
using System.Configuration;

namespace Servicios.Implementacion.Seguridad
{
    public class GestorDeToken : IGestorDeToken
    {
        private readonly string SECRET_KEY = ConfigurationManager.AppSettings["LLaveSecreta"] ?? "ThisIsMySecreTT";
        private readonly static IJsonSerializer serializer = new JsonNetSerializer();
        private readonly static IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
        private readonly static IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
        private readonly static IDateTimeProvider provider = new UtcDateTimeProvider();

        private IJwtEncoder encoder;
        private IJwtDecoder decoder;

        public GestorDeToken()
        {
            IJwtValidator validator = new JwtValidator(serializer, provider);
            this.decoder = new JwtDecoder(serializer, validator, urlEncoder);
            this.encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
        }


        public string GenerarToken(UsuarioLogin usuarioGeneral)
        {
            return encoder.Encode(usuarioGeneral, SECRET_KEY);
        }

        public UsuarioLogin RecuperarInformacionDeUsuario(string token)
        {
            return decoder.DecodeToObject<UsuarioLogin>(token, SECRET_KEY, verify: true);
        }
    }
}
