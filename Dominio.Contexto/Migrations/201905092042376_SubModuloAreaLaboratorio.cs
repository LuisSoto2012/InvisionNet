namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubModuloAreaLaboratorio : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.SubModulo_AreaLaboratorio",
            //    c => new
            //        {
            //            IdSubModulo = c.Int(nullable: false),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdSubModulo, t.IdAreaLaboratorio })
            //    .ForeignKey("dbo.SubModulo", t => t.IdSubModulo, cascadeDelete: true)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdSubModulo)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //DropColumn("dbo.AreaLaboratorio", "PocosFrecuentes");
            //DropColumn("dbo.AreaLaboratorio", "Ups");
            //DropColumn("dbo.AreaLaboratorio", "Calibracion");
            //DropColumn("dbo.AreaLaboratorio", "SueroReferencia");
            //DropColumn("dbo.AreaLaboratorio", "NoCalibrado");
            //DropColumn("dbo.AreaLaboratorio", "HemolizadaLipemica");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.AreaLaboratorio", "HemolizadaLipemica", c => c.Boolean(nullable: false));
            //AddColumn("dbo.AreaLaboratorio", "NoCalibrado", c => c.Boolean(nullable: false));
            //AddColumn("dbo.AreaLaboratorio", "SueroReferencia", c => c.Boolean(nullable: false));
            //AddColumn("dbo.AreaLaboratorio", "Calibracion", c => c.Boolean(nullable: false));
            //AddColumn("dbo.AreaLaboratorio", "Ups", c => c.Boolean(nullable: false));
            //AddColumn("dbo.AreaLaboratorio", "PocosFrecuentes", c => c.Boolean(nullable: false));
            //DropForeignKey("dbo.SubModulo_AreaLaboratorio", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropForeignKey("dbo.SubModulo_AreaLaboratorio", "IdSubModulo", "dbo.SubModulo");
            //DropIndex("dbo.SubModulo_AreaLaboratorio", new[] { "IdAreaLaboratorio" });
            //DropIndex("dbo.SubModulo_AreaLaboratorio", new[] { "IdSubModulo" });
            //DropTable("dbo.SubModulo_AreaLaboratorio");
        }
    }
}
