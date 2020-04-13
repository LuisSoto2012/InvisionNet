namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_Procedimiento_Orden : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdProcedimiento", "dbo.Procedimiento");
            //DropTable("dbo.TipoOrdenMedica_Procedimiento");
            //CreateTable(
            //    "dbo.TipoOrdenMedica_Procedimiento",
            //    c => new
            //        {
            //            IdTipoOrdenMedica_Procedimiento = c.Int(nullable: false, identity: true),
            //            IdTipoOrdenMedica = c.Int(nullable: false),
            //            IdProcedimiento = c.Int(nullable: false),
            //            Orden = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTipoOrdenMedica_Procedimiento)
            //    .ForeignKey("dbo.Procedimiento", t => t.IdProcedimiento, cascadeDelete: true)
            //    .ForeignKey("dbo.TipoOrdenMedica", t => t.IdTipoOrdenMedica, cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.TipoOrdenMedica_Procedimiento",
            //    c => new
            //        {
            //            IdTipoOrdenMedica = c.Int(nullable: false),
            //            IdProcedimiento = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdTipoOrdenMedica, t.IdProcedimiento });
            
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdProcedimiento", "dbo.Procedimiento");
            //DropTable("dbo.TipoOrdenMedica_Procedimiento");
            //AddForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdProcedimiento", "dbo.Procedimiento", "IdProcedimiento", cascadeDelete: true);
            //AddForeignKey("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica", "IdTipoOrdenMedica", cascadeDelete: true);
        }
    }
}
