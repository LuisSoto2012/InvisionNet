namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoRegistrado2 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.PacienteSinResultado", "ResultadoNoRegistrado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.PacienteSinResultado", "ResultadoNoRegistrado", c => c.Int(nullable: false));
        }
    }
}
