namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModuloCrud : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Modulo", "IdUsuarioCreacion", c => c.Int(nullable: false));
            //AddColumn("dbo.Modulo", "IdUsuarioModificacion", c => c.Int());
            //AddColumn("dbo.Modulo", "FechaCreacion", c => c.DateTime(nullable: false));
            //AddColumn("dbo.Modulo", "FechaModificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Modulo", "FechaModificacion");
            //DropColumn("dbo.Modulo", "FechaCreacion");
            //DropColumn("dbo.Modulo", "IdUsuarioModificacion");
            //DropColumn("dbo.Modulo", "IdUsuarioCreacion");
        }
    }
}
