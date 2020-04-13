namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoArchivo : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Archivo", "TipoArchivo", c => c.String(nullable: false, maxLength: 3));
            //DropColumn("dbo.Archivo", "IdTipoArchivo");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Archivo", "IdTipoArchivo", c => c.Int(nullable: false));
            //DropColumn("dbo.Archivo", "TipoArchivo");
        }
    }
}
