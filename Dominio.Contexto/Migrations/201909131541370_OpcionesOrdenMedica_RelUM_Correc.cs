namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpcionesOrdenMedica_RelUM_Correc : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas");
            //DropIndex("dbo.OpcionesOrdenMedica", new[] { "IdOrdenMedica" });
            //AddColumn("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", c => c.Int(nullable: false));
            //CreateIndex("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica");
            //AddForeignKey("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica", "IdTipoOrdenMedica", cascadeDelete: true);
            //DropColumn("dbo.OpcionesOrdenMedica", "IdOrdenMedica");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.OpcionesOrdenMedica", "IdOrdenMedica", c => c.Int(nullable: false));
            //DropForeignKey("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.OpcionesOrdenMedica", new[] { "IdTipoOrdenMedica" });
            //DropColumn("dbo.OpcionesOrdenMedica", "IdTipoOrdenMedica");
            //CreateIndex("dbo.OpcionesOrdenMedica", "IdOrdenMedica");
            //AddForeignKey("dbo.OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas", "IdOrdenMedica", cascadeDelete: true);
        }
    }
}
