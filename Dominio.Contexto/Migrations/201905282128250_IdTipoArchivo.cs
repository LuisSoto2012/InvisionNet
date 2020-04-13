namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdTipoArchivo : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Archivo", "IdTipoArchivo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Archivo", "IdTipoArchivo");
        }
    }
}
