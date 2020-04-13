namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubModuloCrud : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.SubModulo", "IdUsuarioCreacion", c => c.Int(nullable: false));
            //AddColumn("dbo.SubModulo", "IdUsuarioModificacion", c => c.Int());
            //AddColumn("dbo.SubModulo", "FechaCreacion", c => c.DateTime(nullable: false));
            //AddColumn("dbo.SubModulo", "FechaModificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.SubModulo", "FechaModificacion");
            //DropColumn("dbo.SubModulo", "FechaCreacion");
            //DropColumn("dbo.SubModulo", "IdUsuarioModificacion");
            //DropColumn("dbo.SubModulo", "IdUsuarioCreacion");
        }
    }
}
