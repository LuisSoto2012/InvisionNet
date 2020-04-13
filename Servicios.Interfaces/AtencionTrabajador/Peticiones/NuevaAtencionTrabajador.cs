﻿using Servicios.Interfaces.Comunes;
using System.Collections.Generic;

namespace Servicios.Interfaces.AtencionTrabajador.Peticiones
{
    public class NuevaAtencionTrabajador
    {
        public string TipoAtencion { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Presion { get; set; }
        public int? Temperatura { get; set; }
        public int? Peso { get; set; }
        public int? Talla { get; set; }
        public int? Pulso { get; set; }
        public string Motivo { get; set; }
        public int? CantidadDias { get; set; }
        public List<ComboBox> Diagnosticos { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
