namespace Servicios.Interfaces.Paciente.Respuesta
{
    public class PacienteAfiliacion
    {
        public int IdPaciente { get; set; }
        public int? NroHistoriaClinica { get; set; }
        public string NroDocumento { get; set; }
        public string Paciente { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Financiamiento { get; set; }
        public string FechaInscripcion { get; set; }
        public string TipoPaciente { get; set; }
        public string Correo { get; set; }
    }
}
