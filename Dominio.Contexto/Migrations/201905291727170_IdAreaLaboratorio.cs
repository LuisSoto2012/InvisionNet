namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdAreaLaboratorio : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.EmpleoReactivo", "IdAreaLaboratorio", c => c.Int(nullable: false));
            //CreateIndex("dbo.EmpleoReactivo", "IdAreaLaboratorio");
            //AddForeignKey("dbo.EmpleoReactivo", "IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.EmpleoReactivo", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.EmpleoReactivo", new[] { "IdAreaLaboratorio" });
            //DropColumn("dbo.EmpleoReactivo", "IdAreaLaboratorio");
        }
    }
}
