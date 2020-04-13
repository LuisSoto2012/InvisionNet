namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_IdImpresionRevision : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "IdImpresionRevision", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "IdImpresionRevision");
        }
    }
}
