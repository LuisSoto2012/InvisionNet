namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdRolSubModulo : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.RolSubModulo");
            //AddColumn("dbo.RolSubModulo", "IdRolSubModulo", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.RolSubModulo", "IdRolSubModulo");
        }
        
        public override void Down()
        {
            //DropPrimaryKey("dbo.RolSubModulo");
            //DropColumn("dbo.RolSubModulo", "IdRolSubModulo");
            //AddPrimaryKey("dbo.RolSubModulo", new[] { "IdRol", "IdSubModulo" });
        }
    }
}
