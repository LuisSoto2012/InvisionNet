namespace Servicios.Interfaces.Laboratorio.Respuestas
{
    public class MaterialNoCalibradoGeneral
    {
        public int IdMaterialNoCalibrado { get; set; }
        public int IdAreaLaboratorio { get; set; }
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public int Calibrado { get; set; }
        public int NoCalibrado { get; set; }
        public int Inoperativo { get; set; }
        public int Total { get; set; }
        public string AreaLaboratorio { get; set; }
        public bool EsActivo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
