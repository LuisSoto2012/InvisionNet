namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreaLaboratorio_TranscripcionErroneaInoportuna : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TranscripcionErroneaInoportuna", "IdAreaLaboratorio", c => c.Int(nullable: false));
            //CreateIndex("dbo.TranscripcionErroneaInoportuna", "IdAreaLaboratorio");
            //AddForeignKey("dbo.TranscripcionErroneaInoportuna", "IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.TranscripcionErroneaInoportuna", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.TranscripcionErroneaInoportuna", new[] { "IdAreaLaboratorio" });
            //DropColumn("dbo.TranscripcionErroneaInoportuna", "IdAreaLaboratorio");
        }
    }
}
