namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubModuloReporte : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.SubModulo_Reporte",
            //    c => new
            //        {
            //            IdSubModulo = c.Int(nullable: false),
            //            IdReporte = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdSubModulo, t.IdReporte })
            //    .ForeignKey("dbo.SubModulo", t => t.IdSubModulo, cascadeDelete: true)
            //    .ForeignKey("dbo.Reporte", t => t.IdReporte, cascadeDelete: true)
            //    .Index(t => t.IdSubModulo)
            //    .Index(t => t.IdReporte);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.SubModulo_Reporte", "IdReporte", "dbo.Reporte");
            //DropForeignKey("dbo.SubModulo_Reporte", "IdSubModulo", "dbo.SubModulo");
            //DropIndex("dbo.SubModulo_Reporte", new[] { "IdReporte" });
            //DropIndex("dbo.SubModulo_Reporte", new[] { "IdSubModulo" });
            //DropTable("dbo.SubModulo_Reporte");
        }
    }
}
