namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdAtencion_OM : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.OrdenesMedicas", "IdAtencion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.OrdenesMedicas", "IdAtencion");
        }
    }
}
