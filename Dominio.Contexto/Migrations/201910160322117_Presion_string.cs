namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Presion_string : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.AtencionTrabajador", "Presion", c => c.String());
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.AtencionTrabajador", "Presion", c => c.Int());
        }
    }
}
