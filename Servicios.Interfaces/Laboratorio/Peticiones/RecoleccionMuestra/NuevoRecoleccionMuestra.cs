﻿using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoRecoleccionMuestra
    {
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool RecoleccionInapropiada { get; set; }
        public bool MuestrasPerdidas { get; set; }
        public bool MuestrasMalRotuladas { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public string Comentario { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
