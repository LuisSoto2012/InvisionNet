﻿using System;

namespace Servicios.Interfaces.Laboratorio.Peticiones
{
    public class NuevoIncumplimientoAnalisis
    {
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool ElisaHIV { get; set; }
        public bool AnaIFI { get; set; }
        public bool FtaAbsorcion { get; set; }
        public bool ToxoplasmaIggIgm { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public int IdUsuarioCreacion { get; set; }
    }
}
