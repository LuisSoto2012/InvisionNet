namespace Servicios.Interfaces.Paciente.Respuesta
{
    public class PacientePorHcDni
    {
        public int IdPaciente { get; set; }
        public int? NroHistoriaClinica { get; set; }
        public string NroDocumento { get; set; }
        public string Paciente { get; set; }
        public int IdEspecialidad { get; set; }
        public bool Temporal { get; set; }
    }
}
