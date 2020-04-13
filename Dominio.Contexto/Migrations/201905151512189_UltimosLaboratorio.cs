namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UltimosLaboratorio : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.RendimientoHoraTrabajador",
            //    c => new
            //        {
            //            IdRendimientoHoraTrabajador = c.Int(nullable: false, identity: true),
            //            NumeroMes = c.Int(nullable: false),
            //            Horas = c.Int(nullable: false),
            //            ExamenesProcesados = c.Int(nullable: false),
            //            NumeroTrabajadores = c.Int(nullable: false),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdRendimientoHoraTrabajador)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //CreateTable(
            //    "dbo.SolicitudDatosIncompletos",
            //    c => new
            //        {
            //            IdSolicitudDatosIncompletos = c.Int(nullable: false, identity: true),
            //            FechaOcurrencia = c.DateTime(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            FaltaDatos = c.Boolean(nullable: false),
            //            SinMovimiento = c.Boolean(nullable: false),
            //            MovimientoIncorrecto = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdSolicitudDatosIncompletos);
            
            //CreateTable(
            //    "dbo.TranscripcionErronea",
            //    c => new
            //        {
            //            IdTranscripcionErronea = c.Int(nullable: false, identity: true),
            //            FechaOcurrencia = c.DateTime(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            NoCobrado = c.Boolean(nullable: false),
            //            Erroneo = c.Boolean(nullable: false),
            //            SinMovimiento = c.Boolean(nullable: false),
            //            MovimientoIncorrecto = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTranscripcionErronea);
            
            //CreateTable(
            //    "dbo.TranscripcionErroneaInoportuna",
            //    c => new
            //        {
            //            IdTranscripcionErroneaInoportuna = c.Int(nullable: false, identity: true),
            //            FechaOcurrencia = c.DateTime(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            CuadernoOrden = c.Boolean(nullable: false),
            //            OrdenSistema = c.Boolean(nullable: false),
            //            Inoportuna = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTranscripcionErroneaInoportuna);
            
            //AlterColumn("dbo.PocoFrecuente", "NombrePrueba", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.RendimientoHoraTrabajador", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.RendimientoHoraTrabajador", new[] { "IdAreaLaboratorio" });
            //AlterColumn("dbo.PocoFrecuente", "NombrePrueba", c => c.String(nullable: false));
            //DropTable("dbo.TranscripcionErroneaInoportuna");
            //DropTable("dbo.TranscripcionErronea");
            //DropTable("dbo.SolicitudDatosIncompletos");
            //DropTable("dbo.RendimientoHoraTrabajador");
        }
    }
}
