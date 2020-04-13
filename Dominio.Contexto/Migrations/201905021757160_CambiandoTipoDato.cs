namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiandoTipoDato : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.IncidentesPacientes", "FechaOcurrencia", c => c.DateTime(nullable: false));
            //AddColumn("dbo.IncumplimientoAnalisis", "FechaOcurrencia", c => c.DateTime(nullable: false));
            //AddColumn("dbo.PruebasNoRealizadas", "FechaOcurrencia", c => c.DateTime(nullable: false));
            //AddColumn("dbo.RecoleccionMuestra", "FechaOcurrencia", c => c.DateTime(nullable: false));
            //AddColumn("dbo.VenopunturasFallidas", "FechaOcurrencia", c => c.DateTime(nullable: false));
            //AlterColumn("dbo.Aplicacion", "Nombre", c => c.String(nullable: false, maxLength: 100));
            //AlterColumn("dbo.Empleado", "ApellidoPaterno", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.Empleado", "ApellidoMaterno", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.Empleado", "Nombres", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.Empleado", "Correo", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.Empleado", "NumeroDocumento", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.Empleado", "CodigoPlanilla", c => c.String(maxLength: 20));
            //AlterColumn("dbo.Empleado", "Usuario", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.Empleado", "Contrasena", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.CondicionTrabajo", "Descripcion", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.Rol", "Nombre", c => c.String(nullable: false, maxLength: 100));
            //AlterColumn("dbo.TipoDocumentoIdentidad", "Descripcion", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.TipoEmpleado", "Descripcion", c => c.String(nullable: false, maxLength: 200));
            //AlterColumn("dbo.IncidentesPacientes", "HistoriaClinica", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.IncidentesPacientes", "NumeroDocumento", c => c.String(maxLength: 10));
            //AlterColumn("dbo.IncidentesPacientes", "Paciente", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.IncumplimientoAnalisis", "HistoriaClinica", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.IncumplimientoAnalisis", "NumeroDocumento", c => c.String(maxLength: 10));
            //AlterColumn("dbo.IncumplimientoAnalisis", "Paciente", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.IncumplimientoAnalisis", "ElisaHIV", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.IncumplimientoAnalisis", "AnaIFI", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.IncumplimientoAnalisis", "FtaAbsorcion", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.IncumplimientoAnalisis", "ToxoplasmaIggIgm", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.Modulo", "Nombre", c => c.String(nullable: false, maxLength: 100));
            //AlterColumn("dbo.Modulo", "Icono", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.SubModulo", "Nombre", c => c.String(nullable: false, maxLength: 100));
            //AlterColumn("dbo.SubModulo", "Ruta", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.PruebasNoRealizadas", "HistoriaClinica", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.PruebasNoRealizadas", "NumeroDocumento", c => c.String(maxLength: 10));
            //AlterColumn("dbo.PruebasNoRealizadas", "Paciente", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.PruebasNoRealizadas", "Anca", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "AntiCpp", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "AntiDna", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "AntifenosFebriles", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "BartonellaIgg", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "BartonellaIggIgm", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "BkEsputo", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "Cortisol", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "ElisaToxoplasma", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "HlaB27", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "Htlv", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "Mercaptoetanol", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "PerfilTiroideo", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "Ppd", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PruebasNoRealizadas", "Parasitologico", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.RecoleccionMuestra", "HistoriaClinica", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.RecoleccionMuestra", "NumeroDocumento", c => c.String(maxLength: 10));
            //AlterColumn("dbo.RecoleccionMuestra", "Paciente", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.RecoleccionMuestra", "RecoleccionInapropiada", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.RecoleccionMuestra", "MuestrasPerdidas", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.RecoleccionMuestra", "MuestrasMalRotuladas", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.VenopunturasFallidas", "HistoriaClinica", c => c.String(nullable: false, maxLength: 10));
            //AlterColumn("dbo.VenopunturasFallidas", "NumeroDocumento", c => c.String(maxLength: 10));
            //AlterColumn("dbo.VenopunturasFallidas", "Paciente", c => c.String(nullable: false, maxLength: 500));
            //AlterColumn("dbo.VenopunturasFallidas", "PacientesAdultosMayoresONinos", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.VenopunturasFallidas", "VenasDificiles", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.VenopunturasFallidas", "PacienteConPatologiaSubyacente", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.VenopunturasFallidas", "PacienteConPatologiaSubyacente", c => c.String());
            //AlterColumn("dbo.VenopunturasFallidas", "VenasDificiles", c => c.String());
            //AlterColumn("dbo.VenopunturasFallidas", "PacientesAdultosMayoresONinos", c => c.String());
            //AlterColumn("dbo.VenopunturasFallidas", "Paciente", c => c.String());
            //AlterColumn("dbo.VenopunturasFallidas", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.VenopunturasFallidas", "HistoriaClinica", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "MuestrasMalRotuladas", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "MuestrasPerdidas", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "RecoleccionInapropiada", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "Paciente", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.RecoleccionMuestra", "HistoriaClinica", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Parasitologico", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Ppd", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "PerfilTiroideo", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Mercaptoetanol", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Htlv", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "HlaB27", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "ElisaToxoplasma", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Cortisol", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "BkEsputo", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "BartonellaIggIgm", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "BartonellaIgg", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "AntifenosFebriles", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "AntiDna", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "AntiCpp", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Anca", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "Paciente", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.PruebasNoRealizadas", "HistoriaClinica", c => c.String());
            //AlterColumn("dbo.SubModulo", "Ruta", c => c.String());
            //AlterColumn("dbo.SubModulo", "Nombre", c => c.String());
            //AlterColumn("dbo.Modulo", "Icono", c => c.String());
            //AlterColumn("dbo.Modulo", "Nombre", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "ToxoplasmaIggIgm", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "FtaAbsorcion", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "AnaIFI", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "ElisaHIV", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "Paciente", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.IncumplimientoAnalisis", "HistoriaClinica", c => c.String());
            //AlterColumn("dbo.IncidentesPacientes", "Paciente", c => c.String());
            //AlterColumn("dbo.IncidentesPacientes", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.IncidentesPacientes", "HistoriaClinica", c => c.String());
            //AlterColumn("dbo.TipoEmpleado", "Descripcion", c => c.String());
            //AlterColumn("dbo.TipoDocumentoIdentidad", "Descripcion", c => c.String());
            //AlterColumn("dbo.Rol", "Nombre", c => c.String());
            //AlterColumn("dbo.CondicionTrabajo", "Descripcion", c => c.String());
            //AlterColumn("dbo.Empleado", "Contrasena", c => c.String());
            //AlterColumn("dbo.Empleado", "Usuario", c => c.String());
            //AlterColumn("dbo.Empleado", "CodigoPlanilla", c => c.String());
            //AlterColumn("dbo.Empleado", "NumeroDocumento", c => c.String());
            //AlterColumn("dbo.Empleado", "Correo", c => c.String());
            //AlterColumn("dbo.Empleado", "Nombres", c => c.String());
            //AlterColumn("dbo.Empleado", "ApellidoMaterno", c => c.String());
            //AlterColumn("dbo.Empleado", "ApellidoPaterno", c => c.String());
            //AlterColumn("dbo.Aplicacion", "Nombre", c => c.String());
            //DropColumn("dbo.VenopunturasFallidas", "FechaOcurrencia");
            //DropColumn("dbo.RecoleccionMuestra", "FechaOcurrencia");
            //DropColumn("dbo.PruebasNoRealizadas", "FechaOcurrencia");
            //DropColumn("dbo.IncumplimientoAnalisis", "FechaOcurrencia");
            //DropColumn("dbo.IncidentesPacientes", "FechaOcurrencia");
        }
    }
}
