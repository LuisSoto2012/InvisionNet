namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_AtencionEspecialBool : DbMigration
    {
        public override void Up()
        {
           //AlterColumn("dbo.TicketConsultaExterna", "AtencionEspecial", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.TicketConsultaExterna", "AtencionEspecial", c => c.Int(nullable: false));
        }
    }
}
