namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablasLaboratorio3_2 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.CalibracionDeficiente",
            //    c => new
            //        {
            //            IdCalibracionDeficiente = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            EstaCalibrado = c.Boolean(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Observaciones = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdCalibracionDeficiente)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //CreateTable(
            //    "dbo.EmpleoReactivo",
            //    c => new
            //        {
            //            IdEmpleoReactivo = c.Int(nullable: false, identity: true),
            //            TotalDeReactivos = c.Int(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Vencidos = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdEmpleoReactivo);
            
            //CreateTable(
            //    "dbo.EquipoMalCalibrado",
            //    c => new
            //        {
            //            IdEquipoMalCalibrado = c.Int(nullable: false, identity: true),
            //            TotalDeEquipos = c.Int(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Inadecuados = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdEquipoMalCalibrado);
            
            //CreateTable(
            //    "dbo.EquipoUPS",
            //    c => new
            //        {
            //            IdEquipoUPS = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            TieneUPS = c.Boolean(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Observaciones = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdEquipoUPS)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //CreateTable(
            //    "dbo.MaterialNoCalibrado",
            //    c => new
            //        {
            //            IdMaterialNoCalibrado = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Calibrado = c.Int(nullable: false),
            //            NoCalibrado = c.Int(nullable: false),
            //            Inoperativo = c.Int(nullable: false),
            //            Total = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdMaterialNoCalibrado)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //CreateTable(
            //    "dbo.MuestraHemolizadaLipemica",
            //    c => new
            //        {
            //            IdCalibracionDeficiente = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            NumeroMes = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdCalibracionDeficiente)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //CreateTable(
            //    "dbo.SueroMalReferenciado",
            //    c => new
            //        {
            //            IdSueroMalReferenciado = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            TieneReferencia = c.Boolean(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Observaciones = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdSueroMalReferenciado)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.SueroMalReferenciado", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropForeignKey("dbo.MuestraHemolizadaLipemica", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropForeignKey("dbo.MaterialNoCalibrado", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropForeignKey("dbo.EquipoUPS", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropForeignKey("dbo.CalibracionDeficiente", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.SueroMalReferenciado", new[] { "IdAreaLaboratorio" });
            //DropIndex("dbo.MuestraHemolizadaLipemica", new[] { "IdAreaLaboratorio" });
            //DropIndex("dbo.MaterialNoCalibrado", new[] { "IdAreaLaboratorio" });
            //DropIndex("dbo.EquipoUPS", new[] { "IdAreaLaboratorio" });
            //DropIndex("dbo.CalibracionDeficiente", new[] { "IdAreaLaboratorio" });
            //DropTable("dbo.SueroMalReferenciado");
            //DropTable("dbo.MuestraHemolizadaLipemica");
            //DropTable("dbo.MaterialNoCalibrado");
            //DropTable("dbo.EquipoUPS");
            //DropTable("dbo.EquipoMalCalibrado");
            //DropTable("dbo.EmpleoReactivo");
            //DropTable("dbo.CalibracionDeficiente");
        }
    }
}
