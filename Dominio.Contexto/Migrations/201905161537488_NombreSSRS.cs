namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombreSSRS : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Reporte", "NombreSSRS", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Reporte", "NombreSSRS");
        }
    }
}
