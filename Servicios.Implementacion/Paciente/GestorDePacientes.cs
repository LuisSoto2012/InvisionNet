using Dominio.Contexto;
using Servicios.Interfaces.Paciente;
using Servicios.Interfaces.Paciente.Peticiones;
using Servicios.Interfaces.Paciente.Respuesta;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Servicios.Implementacion.Paciente
{
    public class GestorDePacientes : IGestorDePacientes
    {
        public List<HistorialAtenciones> ListarHistorialAtenciones(PacientePorHcDni paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var ds = paciente.NroHistoriaClinica.Value;
                return db.Database.SqlQuery<HistorialAtenciones>("dbo.INO_CEHistorialAtenciones @NroHistoriaClinica",
                        new SqlParameter("NroHistoriaClinica", paciente.NroHistoriaClinica.Value)).ToList();
            }
        }

        public List<HistorialCentroQuirurgico> ListarHistorialCentroQuirurgico(PacientePorHcDni paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<HistorialCentroQuirurgico>("dbo.INO_CEHistorialAtencionesCQ @NroHistoriaClinica",
                        new SqlParameter("NroHistoriaClinica", paciente.NroHistoriaClinica.Value)).ToList();
            }
        }

        public List<HistorialEmergencia> ListarHistorialEmergencia(PacientePorHcDni paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<HistorialEmergencia>("dbo.INO_CEHistorialEmergencia @NroHistoriaClinica",
                        new SqlParameter("NroHistoriaClinica", paciente.NroHistoriaClinica.Value)).ToList();
            }
        }

        public List<HistorialLaboratorio> ListarHistorialLaboratorio(PacientePorHcDni paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<HistorialLaboratorio>("dbo.INO_CEHistorialLaboratorio @NroHistoriaClinica",
                        new SqlParameter("NroHistoriaClinica", paciente.NroHistoriaClinica.Value)).ToList();
            }
        }

        public List<HistorialRiesgoQuirurgico> ListarHistorialRiesgoQuirurgico(PacientePorHcDni paciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                return db.Database.SqlQuery<HistorialRiesgoQuirurgico>("dbo.INO_HistoricoEKG @hcl",
                        new SqlParameter("hcl", paciente.NroHistoriaClinica.Value)).ToList();
            }
        }

        public PacienteAfiliacion ListarPacientePorHcDni(PacientePorHcDni pacientePorHcDni)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var Hc = new SqlParameter("Hc", pacientePorHcDni.NroHistoriaClinica);
                Hc.Value = (object)pacientePorHcDni.NroHistoriaClinica ?? DBNull.Value;
                var Dni = new SqlParameter("Dni", pacientePorHcDni.NroDocumento);
                Dni.Value = (object)pacientePorHcDni.NroDocumento ?? DBNull.Value;
                var Temp = new SqlParameter("Temp", pacientePorHcDni.Temporal);

                return db.Database.SqlQuery<PacienteAfiliacion>("dbo.INO_BuscarPacientePorHCDNI @Hc, @Dni, @Temp", Hc, Dni, Temp).FirstOrDefault();
            }
        }

        public List<PacientePorHcDni> ListarPacientesCitadosPorEspecialidadMedicoFecha(BuscarPaciente buscarPaciente)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var pacientesCitados = db.Database.SqlQuery<PacientePorHcDni>("dbo.INO_PacientesCitadosListarPorEspecialidadMedicoFecha @Fecha, @IdMedico, @IdEspecialidad",
                        new SqlParameter("Fecha", buscarPaciente.Fecha),
                        new SqlParameter("IdMedico", buscarPaciente.IdMedico),
                        new SqlParameter("IdEspecialidad", buscarPaciente.IdEspecialidad)).ToList();
                return pacientesCitados;
            }
        }

        public PacienteCitado ListarPacienteCitadoDelDia(PacientePorHcDni pacientePorHcDni)
        {
            using (GalenPlusBD db = new GalenPlusBD())
            {
                var Hc = new SqlParameter("NroHistoria", pacientePorHcDni.NroHistoriaClinica);
                Hc.Value = (object)pacientePorHcDni.NroHistoriaClinica ?? DBNull.Value;
                var Dni = new SqlParameter("NroDocumento", pacientePorHcDni.NroDocumento);
                Dni.Value = (object)pacientePorHcDni.NroDocumento ?? DBNull.Value;
                var IdEspecialidad = new SqlParameter("IdEspecialidad", pacientePorHcDni.IdEspecialidad);

                return db.Database.SqlQuery<PacienteCitado>("dbo.INO_ArchivoPedirHCPacientes @NroHistoria, @NroDocumento, @IdEspecialidad",Hc, Dni, IdEspecialidad).FirstOrDefault();
            }
        }
    }
}
