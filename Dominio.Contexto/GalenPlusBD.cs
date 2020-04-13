using System.Data.Entity;

namespace Dominio.Contexto
{
    public class GalenPlusBD : DbContext
    {
        public GalenPlusBD() : base("GalenPlusBD") { }
    }
}
