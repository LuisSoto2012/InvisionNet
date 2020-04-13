namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComentarioLaboratorio : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.RecoleccionMuestra", "Comentario", c => c.String());
            //AddColumn("dbo.TranscripcionErroneaInoportuna", "Comentario", c => c.String());
            //AddColumn("dbo.VenopunturasFallidas", "Comentario", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.VenopunturasFallidas", "Comentario");
            //DropColumn("dbo.TranscripcionErroneaInoportuna", "Comentario");
            //DropColumn("dbo.RecoleccionMuestra", "Comentario");
        }
    }
}
