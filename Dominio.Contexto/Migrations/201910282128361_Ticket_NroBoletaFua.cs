namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticket_NroBoletaFua : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "NroBoletaFua", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "NroBoletaFua");
        }
    }
}
