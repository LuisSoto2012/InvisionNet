namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablasLaboratorioCorreccion : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.MuestraHemolizadaLipemica");
            //AddColumn("dbo.MuestraHemolizadaLipemica", "IdMuestraHemolizadaLipemica", c => c.Int(nullable: false, identity: false));
            //AddPrimaryKey("dbo.MuestraHemolizadaLipemica", "IdMuestraHemolizadaLipemica");
            //DropColumn("dbo.MuestraHemolizadaLipemica", "IdCalibracionDeficiente");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.MuestraHemolizadaLipemica", "IdCalibracionDeficiente", c => c.Int(nullable: false, identity: true));
            //DropPrimaryKey("dbo.MuestraHemolizadaLipemica");
            //DropColumn("dbo.MuestraHemolizadaLipemica", "IdMuestraHemolizadaLipemica");
            //AddPrimaryKey("dbo.MuestraHemolizadaLipemica", "IdCalibracionDeficiente");
        }
    }
}
