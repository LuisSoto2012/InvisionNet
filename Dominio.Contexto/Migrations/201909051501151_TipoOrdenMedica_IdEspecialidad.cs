namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_IdEspecialidad : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TipoOrdenMedica", "IdEspecialidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TipoOrdenMedica", "IdEspecialidad");
        }
    }
}
