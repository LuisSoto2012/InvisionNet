namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_Procedimiento_Id : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.TipoOrdenMedica_Procedimiento");
            //DropColumn("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica_Procedimiento");
            //AddColumn("dbo.TipoOrdenMedica_Procedimiento", "Id", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.TipoOrdenMedica_Procedimiento", "Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica_Procedimiento", c => c.Int(nullable: false, identity: true));
            //DropPrimaryKey("dbo.TipoOrdenMedica_Procedimiento");
            //DropColumn("dbo.TipoOrdenMedica_Procedimiento", "Id");
            //AddPrimaryKey("dbo.TipoOrdenMedica_Procedimiento", "IdTipoOrdenMedica_Procedimiento");
        }
    }
}
