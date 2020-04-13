namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TamanoDialog : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Reporte", "TamanoDialog", c => c.Int(nullable: false));
            //AddColumn("dbo.TranscripcionErroneaInoportuna", "OrdenSistema", c => c.Boolean(nullable: false));
            //DropColumn("dbo.TranscripcionErroneaInoportuna", "OrdenSistena");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.TranscripcionErroneaInoportuna", "OrdenSistena", c => c.Boolean(nullable: false));
            //DropColumn("dbo.TranscripcionErroneaInoportuna", "OrdenSistema");
            //DropColumn("dbo.Reporte", "TamanoDialog");
        }
    }
}
