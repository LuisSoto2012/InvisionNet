namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IpLogueo : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Auditoria", "IpLogueo", c => c.String(maxLength: 50));
            //DropColumn("dbo.Auditoria", "IpLogeuo");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Auditoria", "IpLogeuo", c => c.String(maxLength: 50));
            //DropColumn("dbo.Auditoria", "IpLogueo");
        }
    }
}
