namespace Servicios.Interfaces.Paciente.Respuesta
{
    public class PacienteCitado
    {
        public int IdPaciente { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string NroDocumento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PrimerNombre { get; set; }
        public string Especialidad { get; set; }
        public string Servicio { get; set; }
        public int IdArchivo { get; set; }
    }
}
