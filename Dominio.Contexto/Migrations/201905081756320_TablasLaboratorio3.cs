namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablasLaboratorio3 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.PocoFrecuente",
            //    c => new
            //        {
            //            IdPocoFrecuente = c.Int(nullable: false, identity: true),
            //            IdAreaLaboratorio = c.Int(nullable: false),
            //            IdPrueba = c.Int(nullable: false),
            //            NumeroMes = c.Int(nullable: false),
            //            Total = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdPocoFrecuente)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
            
            //AddColumn("dbo.AreaLaboratorio", "HemolizadaLipemica", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.PocoFrecuente", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.PocoFrecuente", new[] { "IdAreaLaboratorio" });
            //DropColumn("dbo.AreaLaboratorio", "HemolizadaLipemica");
            //DropTable("dbo.PocoFrecuente");
        }
    }
}
