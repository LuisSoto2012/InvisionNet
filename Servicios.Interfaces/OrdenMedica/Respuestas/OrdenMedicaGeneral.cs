using Servicios.Interfaces.Comunes;
using System;
using System.Collections.Generic;

namespace Servicios.Interfaces.OrdenMedica.Respuestas
{
    public class OrdenMedicaGeneral
    {
        public int IdOrdenMedica { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Fecha { get; set; }
        public int IdTipoAnestesia { get; set; }
        public int IdTipoUsuario { get; set; }
        public string FechaRegistro { get; set; }
        public string NombreEspecialidad { get; set; }
        public virtual ComboBox TipoOrdenMedica { get; set; }
        public virtual List<OrdenesMedicasCodigosGeneral> OrdenesMedicasCodigos { get; set; }
    }
}
