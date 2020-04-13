namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialMigration : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Aplicacion",
            //    c => new
            //        {
            //            IdAplicacion = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdAplicacion);
            
            //CreateTable(
            //    "dbo.Empleado",
            //    c => new
            //        {
            //            IdEmpleado = c.Int(nullable: false, identity: true),
            //            ApellidoPaterno = c.String(),
            //            ApellidoMaterno = c.String(),
            //            Nombres = c.String(),
            //            Correo = c.String(),
            //            IdCondicionTrabajo = c.Int(nullable: false),
            //            IdTipoEmpleado = c.Int(nullable: false),
            //            IdTipoDocumento = c.Int(nullable: false),
            //            NumeroDocumento = c.String(),
            //            CodigoPlanilla = c.String(),
            //            Usuario = c.String(),
            //            Contrasena = c.String(),
            //            LoginEstado = c.Boolean(nullable: false),
            //            LoginIp = c.String(),
            //            FechaNacimiento = c.DateTime(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdEmpleado)
            //    .ForeignKey("dbo.CondicionTrabajo", t => t.IdCondicionTrabajo, cascadeDelete: true)
            //    .ForeignKey("dbo.TipoDocumentoIdentidad", t => t.IdTipoDocumento, cascadeDelete: true)
            //    .ForeignKey("dbo.TipoEmpleado", t => t.IdTipoEmpleado, cascadeDelete: true)
            //    .Index(t => t.IdCondicionTrabajo)
            //    .Index(t => t.IdTipoEmpleado)
            //    .Index(t => t.IdTipoDocumento);
            
            //CreateTable(
            //    "dbo.CondicionTrabajo",
            //    c => new
            //        {
            //            IdCondicionTrabajo = c.Int(nullable: false, identity: true),
            //            Descripcion = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdCondicionTrabajo);
            
            //CreateTable(
            //    "dbo.Rol",
            //    c => new
            //        {
            //            IdRol = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdRol);
            
            //CreateTable(
            //    "dbo.TipoDocumentoIdentidad",
            //    c => new
            //        {
            //            IdTipoDocumentoIdentidad = c.Int(nullable: false, identity: true),
            //            Descripcion = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTipoDocumentoIdentidad);
            
            //CreateTable(
            //    "dbo.TipoEmpleado",
            //    c => new
            //        {
            //            IdTipoEmpleado = c.Int(nullable: false, identity: true),
            //            Descripcion = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTipoEmpleado);
            
            //CreateTable(
            //    "dbo.IncidentesPacientes",
            //    c => new
            //        {
            //            IdIncidentesPacientes = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(),
            //            NumeroDocumento = c.String(),
            //            Paciente = c.String(),
            //            Incidentes = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdIncidentesPacientes);
            
            //CreateTable(
            //    "dbo.IncumplimientoAnalisis",
            //    c => new
            //        {
            //            IdIncumplimientoAnalisis = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(),
            //            NumeroDocumento = c.String(),
            //            Paciente = c.String(),
            //            ElisaHIV = c.String(),
            //            AnaIFI = c.String(),
            //            FtaAbsorcion = c.String(),
            //            ToxoplasmaIggIgm = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdIncumplimientoAnalisis);
            
            //CreateTable(
            //    "dbo.Modulo",
            //    c => new
            //        {
            //            IdModulo = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(),
            //            Orden = c.Int(nullable: false),
            //            Icono = c.String(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdModulo);
            
            //CreateTable(
            //    "dbo.SubModulo",
            //    c => new
            //        {
            //            IdSubModulo = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(),
            //            Orden = c.Int(nullable: false),
            //            Ruta = c.String(),
            //            EsActivo = c.Boolean(nullable: false),
            //            IdModulo = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdSubModulo)
            //    .ForeignKey("dbo.Modulo", t => t.IdModulo, cascadeDelete: true)
            //    .Index(t => t.IdModulo);
            
            //CreateTable(
            //    "dbo.PruebasNoRealizadas",
            //    c => new
            //        {
            //            IdPruebasNoRealizadas = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(),
            //            NumeroDocumento = c.String(),
            //            Paciente = c.String(),
            //            Anca = c.String(),
            //            AntiCpp = c.String(),
            //            AntiDna = c.String(),
            //            AntifenosFebriles = c.String(),
            //            BartonellaIgg = c.String(),
            //            BartonellaIggIgm = c.String(),
            //            BkEsputo = c.String(),
            //            Cortisol = c.String(),
            //            ElisaToxoplasma = c.String(),
            //            HlaB27 = c.String(),
            //            Htlv = c.String(),
            //            Mercaptoetanol = c.String(),
            //            PerfilTiroideo = c.String(),
            //            Ppd = c.String(),
            //            Parasitologico = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdPruebasNoRealizadas);
            
            //CreateTable(
            //    "dbo.RecoleccionMuestra",
            //    c => new
            //        {
            //            IdRecoleccionMuestra = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(),
            //            NumeroDocumento = c.String(),
            //            Paciente = c.String(),
            //            RecoleccionInapropiada = c.String(),
            //            MuestrasPerdidas = c.String(),
            //            MuestrasMalRotuladas = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdRecoleccionMuestra);
            
            //CreateTable(
            //    "dbo.RolSubModulo",
            //    c => new
            //        {
            //            IdRol = c.Int(nullable: false),
            //            IdSubModulo = c.Int(nullable: false),
            //            Ver = c.Boolean(nullable: false),
            //            Agregar = c.Boolean(nullable: false),
            //            Editar = c.Boolean(nullable: false),
            //            Eliminar = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdRol, t.IdSubModulo })
            //    .ForeignKey("dbo.Rol", t => t.IdRol, cascadeDelete: true)
            //    .ForeignKey("dbo.SubModulo", t => t.IdSubModulo, cascadeDelete: true)
            //    .Index(t => t.IdRol)
            //    .Index(t => t.IdSubModulo);
            
            //CreateTable(
            //    "dbo.VenopunturasFallidas",
            //    c => new
            //        {
            //            IdVenopunturasFallidas = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(),
            //            NumeroDocumento = c.String(),
            //            Paciente = c.String(),
            //            PacientesAdultosMayoresONinos = c.String(),
            //            VenasDificiles = c.String(),
            //            PacienteConPatologiaSubyacente = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdVenopunturasFallidas);
            
            //CreateTable(
            //    "dbo.AplicacionEmpleado",
            //    c => new
            //        {
            //            IdEmpleado = c.Int(nullable: false),
            //            IdAplicacion = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdEmpleado, t.IdAplicacion })
            //    .ForeignKey("dbo.Empleado", t => t.IdEmpleado, cascadeDelete: true)
            //    .ForeignKey("dbo.Aplicacion", t => t.IdAplicacion, cascadeDelete: true)
            //    .Index(t => t.IdEmpleado)
            //    .Index(t => t.IdAplicacion);
            
            //CreateTable(
            //    "dbo.UsuarioRol",
            //    c => new
            //        {
            //            IdEmpleado = c.Int(nullable: false),
            //            IdRol = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdEmpleado, t.IdRol })
            //    .ForeignKey("dbo.Empleado", t => t.IdEmpleado, cascadeDelete: true)
            //    .ForeignKey("dbo.Rol", t => t.IdRol, cascadeDelete: true)
            //    .Index(t => t.IdEmpleado)
            //    .Index(t => t.IdRol);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.RolSubModulo", "IdSubModulo", "dbo.SubModulo");
            //DropForeignKey("dbo.RolSubModulo", "IdRol", "dbo.Rol");
            //DropForeignKey("dbo.SubModulo", "IdModulo", "dbo.Modulo");
            //DropForeignKey("dbo.Empleado", "IdTipoEmpleado", "dbo.TipoEmpleado");
            //DropForeignKey("dbo.Empleado", "IdTipoDocumento", "dbo.TipoDocumentoIdentidad");
            //DropForeignKey("dbo.UsuarioRol", "IdRol", "dbo.Rol");
            //DropForeignKey("dbo.UsuarioRol", "IdEmpleado", "dbo.Empleado");
            //DropForeignKey("dbo.Empleado", "IdCondicionTrabajo", "dbo.CondicionTrabajo");
            //DropForeignKey("dbo.AplicacionEmpleado", "IdAplicacion", "dbo.Aplicacion");
            //DropForeignKey("dbo.AplicacionEmpleado", "IdEmpleado", "dbo.Empleado");
            //DropIndex("dbo.UsuarioRol", new[] { "IdRol" });
            //DropIndex("dbo.UsuarioRol", new[] { "IdEmpleado" });
            //DropIndex("dbo.AplicacionEmpleado", new[] { "IdAplicacion" });
            //DropIndex("dbo.AplicacionEmpleado", new[] { "IdEmpleado" });
            //DropIndex("dbo.RolSubModulo", new[] { "IdSubModulo" });
            //DropIndex("dbo.RolSubModulo", new[] { "IdRol" });
            //DropIndex("dbo.SubModulo", new[] { "IdModulo" });
            //DropIndex("dbo.Empleado", new[] { "IdTipoDocumento" });
            //DropIndex("dbo.Empleado", new[] { "IdTipoEmpleado" });
            //DropIndex("dbo.Empleado", new[] { "IdCondicionTrabajo" });
            //DropTable("dbo.UsuarioRol");
            //DropTable("dbo.AplicacionEmpleado");
            //DropTable("dbo.VenopunturasFallidas");
            //DropTable("dbo.RolSubModulo");
            //DropTable("dbo.RecoleccionMuestra");
            //DropTable("dbo.PruebasNoRealizadas");
            //DropTable("dbo.SubModulo");
            //DropTable("dbo.Modulo");
            //DropTable("dbo.IncumplimientoAnalisis");
            //DropTable("dbo.IncidentesPacientes");
            //DropTable("dbo.TipoEmpleado");
            //DropTable("dbo.TipoDocumentoIdentidad");
            //DropTable("dbo.Rol");
            //DropTable("dbo.CondicionTrabajo");
            //DropTable("dbo.Empleado");
            //DropTable("dbo.Aplicacion");
        }
    }
}
