namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescripcionCorta : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Procedimiento", "DescripcionCorta", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Procedimiento", "DescripcionCorta");
        }
    }
}
