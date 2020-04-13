namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoRegistrado : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.PacienteSinResultado", "ResultadoNoRegistrado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.PacienteSinResultado", "ResultadoNoRegistrado");
        }
    }
}
