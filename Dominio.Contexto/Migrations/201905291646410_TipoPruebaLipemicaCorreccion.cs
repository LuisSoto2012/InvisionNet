namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoPruebaLipemicaCorreccion : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MuestraHemolizadaLipemica", "TipoPrueba", c => c.String(nullable: false, maxLength: 20));
            //DropColumn("dbo.MuestraHemolizadaLipemica", "IdTipoPrueba");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.MuestraHemolizadaLipemica", "IdTipoPrueba", c => c.Int(nullable: false));
            //DropColumn("dbo.MuestraHemolizadaLipemica", "TipoPrueba");
        }
    }
}
