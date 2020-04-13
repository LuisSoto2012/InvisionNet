namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescripcionSSRS : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Reporte", "Descripcion", c => c.String(nullable: false));
            //DropColumn("dbo.Reporte", "Ruta");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Reporte", "Ruta", c => c.String(nullable: false));
            //DropColumn("dbo.Reporte", "Descripcion");
        }
    }
}
