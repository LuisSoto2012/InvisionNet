namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_IdTurno : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "IdTurno", c => c.Int(nullable: false));
            //AlterColumn("dbo.TicketConsultaExterna", "Medico", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.TicketConsultaExterna", "Medico", c => c.String(nullable: false, maxLength: 500));
            //DropColumn("dbo.TicketConsultaExterna", "IdTurno");
        }
    }
}
