using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Ticket.Peticiones
{
    public class ActualizarTicketConsultaExterna
    {
        public int IdTicketConsultaExterna { get; set; }
        public int IdImpresion { get; set; }
        public int IdImpresionRevision { get; set; }
    }
}
