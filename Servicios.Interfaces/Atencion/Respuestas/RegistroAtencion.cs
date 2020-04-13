using System;

namespace Servicios.Interfaces.Atencion.Respuestas
{
    public class RegistroAtencion
    {
        public int Id { get; set; }
        public int IdCita { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string Paciente { get; set; }
        public int IdMedico { get; set; }
        public string Medico { get; set; }
        public int IdEspecialidad { get; set; }
        public string Especialidad { get; set; }
        public int IdServicio { get; set; }
        public string Servicio { get; set; }
        public string Financiamiento { get; set; }
        public string Diacod1 { get; set; }
        public string Diades1 { get; set; }
        public int IdTipoDiagnostico1 { get; set; }
        public string Diacod2 { get; set; }
        public string Diades2 { get; set; }
        public int IdTipoDiagnostico2 { get; set; }
        public string Diacod3 { get; set; }
        public string Diades3 { get; set; }
        public int IdTipoDiagnostico3 { get; set; }
        public DateTime FechaAtencion { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string CodProc1 { get; set; }
        public string Coddes1 { get; set; }
        public string CodProc2 { get; set; }
        public string Coddes2 { get; set; }
        public string CodProc3 { get; set; }
        public string Coddes3 { get; set; }
        public int IdResidente { get; set; }
        public string Residente { get; set; }
        public int IdTipoCondicionEstablecimiento { get; set; }
        public int IdTipoCondicionServicio { get; set; }
        public string Diacod1_OI { get; set; }
        public string Diades1_OI { get; set; }
        public int IdTipoDiagnostico1_OI { get; set; }
        public string Diacod2_OI { get; set; }
        public string Diades2_OI { get; set; }
        public int IdTipoDiagnostico2_OI { get; set; }
        public string Diacod3_OI { get; set; }
        public string Diades3_OI { get; set; }
        public int IdTipoDiagnostico3_OI { get; set; }
        public string CodProc1_OI { get; set; }
        public string Coddes1_OI { get; set; }
        public string CodProc2_OI { get; set; }
        public string Coddes2_OI { get; set; }
        public string CodProc3_OI { get; set; }
        public string Coddes3_OI { get; set; }
        public string Avod { get; set; }
        public string Avoi { get; set; }
    }
}
