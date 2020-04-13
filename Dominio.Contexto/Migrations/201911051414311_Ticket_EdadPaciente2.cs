namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_EdadPaciente2 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.TicketConsultaExterna", "Edad");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.TicketConsultaExterna", "Edad", c => c.Int(nullable: false));
        }
    }
}
