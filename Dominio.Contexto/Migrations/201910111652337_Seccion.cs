namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seccion : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.EscalafonDeLegajos", "Seccion", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.EscalafonDeLegajos", "Seccion");
        }
    }
}
