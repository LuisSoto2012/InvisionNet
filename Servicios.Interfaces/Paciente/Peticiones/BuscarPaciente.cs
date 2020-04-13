using System;

namespace Servicios.Interfaces.Paciente.Peticiones
{
    public class BuscarPaciente
    {
        public DateTime Fecha { get; set; }
        public int IdMedico { get; set; }
        public int IdEspecialidad { get; set; }
    }
}
