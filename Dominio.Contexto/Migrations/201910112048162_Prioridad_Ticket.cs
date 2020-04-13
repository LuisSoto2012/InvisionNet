namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prioridad_Ticket : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "Prioridad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "Prioridad");
        }
    }
}
