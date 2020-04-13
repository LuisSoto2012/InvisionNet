namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnImagen : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Reporte", "Imagen", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Reporte", "Imagen");
        }
    }
}
