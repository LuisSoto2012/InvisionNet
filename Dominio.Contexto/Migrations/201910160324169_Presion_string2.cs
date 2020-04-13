namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Presion_string2 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.AtencionTrabajador", "Presion", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.AtencionTrabajador", "Presion", c => c.String());
        }
    }
}
