namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoPatologia : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.OrdenesMedicas", "TipoPatologia", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.OrdenesMedicas", "TipoPatologia");
        }
    }
}
