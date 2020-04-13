namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_Proc : DbMigration
    {
        public override void Up()
        {
            //    AddColumn("dbo.Procedimiento", "IdTipoOrdenMedica", c => c.Int());
            //    CreateIndex("dbo.Procedimiento", "IdTipoOrdenMedica");
            //    AddForeignKey("dbo.Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica", "IdTipoOrdenMedica");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Procedimiento", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.Procedimiento", new[] { "IdTipoOrdenMedica" });
            //DropColumn("dbo.Procedimiento", "IdTipoOrdenMedica");
        }
    }
}
