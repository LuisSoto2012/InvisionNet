namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class IncumplimientoAnalisisGeneral
    {
        public int IdIncumplimientoAnalisis { get; set; }
        public string HistoriaClinica { get; set; }
        public string NumeroDocumento { get; set; }
        public string Paciente { get; set; }
        public bool ElisaHIV { get; set; }
        public bool AnaIFI { get; set; }
        public bool FtaAbsorcion { get; set; }
        public bool ToxoplasmaIggIgm { get; set; }
        public string FechaOcurrencia { get; set; }
        public bool EsActivo { get; set; }
    }
}
