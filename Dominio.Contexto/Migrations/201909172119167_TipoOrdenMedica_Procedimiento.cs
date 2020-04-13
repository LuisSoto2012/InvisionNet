namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_Procedimiento : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.Procedimiento", new[] { "IdTipoOrdenMedica" });
            //CreateTable(
            //    "dbo.TipoOrdenMedica_Procedimiento",
            //    c => new
            //        {
            //            IdTipoOrdenMedica = c.Int(nullable: false),
            //            IdProcedimiento = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdTipoOrdenMedica, t.IdProcedimiento })
            //    .ForeignKey("dbo.TipoOrdenMedica", t => t.IdTipoOrdenMedica, cascadeDelete: true)
            //    .ForeignKey("dbo.Procedimiento", t => t.IdProcedimiento, cascadeDelete: true)
            //    .Index(t => t.IdTipoOrdenMedica)
            //    .Index(t => t.IdProcedimiento);
            
            //DropColumn("dbo.Procedimiento", "IdTipoOrdenMedica");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Procedimiento", "IdTipoOrdenMedica", c => c.Int());
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdProcedimiento", "dbo.Procedimiento");
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.TipoOrdenMedica_Procedimiento", new[] { "IdProcedimiento" });
            //DropIndex("dbo.TipoOrdenMedica_Procedimiento", new[] { "IdTipoOrdenMedica" });
            //DropTable("dbo.TipoOrdenMedica_Procedimiento");
            //CreateIndex("dbo.Procedimiento", "IdTipoOrdenMedica");
            //AddForeignKey("dbo.Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica", "IdTipoOrdenMedica");
        }
    }
}
