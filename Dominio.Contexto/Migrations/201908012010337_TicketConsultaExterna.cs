namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketConsultaExterna : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.TicketConsultaExterna",
            //    c => new
            //        {
            //            IdTicketConsultaExterna = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            IdEspecialidad = c.Int(nullable: false),
            //            Contador = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTicketConsultaExterna);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.TicketConsultaExterna");
        }
    }
}
