namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Archivo_AgregarNumeroDocumento : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Archivo", "NroDocumento", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Archivo", "NroDocumento");
        }
    }
}
