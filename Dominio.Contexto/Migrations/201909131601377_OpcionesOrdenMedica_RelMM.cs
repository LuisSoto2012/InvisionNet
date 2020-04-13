namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpcionesOrdenMedica_RelMM : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.OpcionesOrdenMedica", new[] { "IdTipoOrdenMedica" });
            //CreateTable(
            //    "dbo.OrdenesMedicas_OpcionesOrdenMedica",
            //    c => new
            //        {
            //            IdOrdenMedica = c.Int(nullable: false),
            //            IdOpcionOrdenMedica = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdOrdenMedica, t.IdOpcionOrdenMedica })
            //    .ForeignKey("dbo.OrdenesMedicas", t => t.IdOrdenMedica, cascadeDelete: true)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.IdOpcionOrdenMedica, cascadeDelete: true)
            //    .Index(t => t.IdOrdenMedica)
            //    .Index(t => t.IdOpcionOrdenMedica);
            
            //DropColumn("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", c => c.Int(nullable: false));
            //DropForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOpcionOrdenMedica", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas");
            //DropIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", new[] { "IdOpcionOrdenMedica" });
            //DropIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", new[] { "IdOrdenMedica" });
            //DropTable("dbo.OrdenesMedicas_OpcionesOrdenMedica");
            //CreateIndex("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica");
            //AddForeignKey("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica", "IdTipoOrdenMedica", cascadeDelete: true);
        }
    }
}
