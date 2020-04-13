namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdPaciente_TicketConsultaExterna : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TicketConsultaExterna", "IdPaciente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TicketConsultaExterna", "IdPaciente");
        }
    }
}
