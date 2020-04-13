namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoImpreso : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.PacienteSinResultado", "ResultadoNoImpreso", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.PacienteSinResultado", "ResultadoNoImpreso");
        }
    }
}
