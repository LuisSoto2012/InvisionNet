namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nombreprueba : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.PocoFrecuente", "NombrePrueba", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.PocoFrecuente", "NombrePrueba");
        }
    }
}
