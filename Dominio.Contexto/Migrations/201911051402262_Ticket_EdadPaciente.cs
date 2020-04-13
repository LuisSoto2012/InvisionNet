namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_EdadPaciente : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "Edad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "Edad");
        }
    }
}
