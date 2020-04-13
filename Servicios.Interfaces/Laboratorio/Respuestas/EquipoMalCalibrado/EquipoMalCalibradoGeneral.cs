using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class EquipoMalCalibradoGeneral
    {
        public int IdEquipoMalCalibrado { get; set; }
        public int TotalDeEquipos { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public int Inadecuados { get; set; }
        public bool EsActivo { get; set; }
        public string AreaLaboratorio { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public string FechaCreacion { get; set; }
    }
}
