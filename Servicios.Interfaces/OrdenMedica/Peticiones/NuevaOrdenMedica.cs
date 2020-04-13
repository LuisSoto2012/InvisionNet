using System;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Peticiones
{
    public class NuevaOrdenMedica
    {
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTipoOrdenMedica { get; set; }
        public int IdAtencion { get; set; }
        public int IdTipoAnestesia { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }
        public List<NuevaOrdenesMedicasCodigos> OrdenesMedicasCodigos { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
