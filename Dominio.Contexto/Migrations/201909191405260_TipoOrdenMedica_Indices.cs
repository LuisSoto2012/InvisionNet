namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedica_Indices : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TipoOrdenMedica", "TamanoFormulario", c => c.Int(nullable: false));
            //AddColumn("dbo.TipoOrdenMedica", "TituloFormulario", c => c.String(maxLength: 100));
            //AddColumn("dbo.TipoOrdenMedica", "Indices", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TipoOrdenMedica", "Indices");
            //DropColumn("dbo.TipoOrdenMedica", "TituloFormulario");
            //DropColumn("dbo.TipoOrdenMedica", "TamanoFormulario");
        }
    }
}
