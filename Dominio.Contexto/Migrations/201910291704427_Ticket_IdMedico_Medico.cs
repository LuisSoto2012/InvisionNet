namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_IdMedico_Medico : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "IdMedico", c => c.Int(nullable: false));
            //AddColumn("dbo.TicketConsultaExterna", "Medico", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "Medico");
            //DropColumn("dbo.TicketConsultaExterna", "IdMedico");
        }
    }
}
