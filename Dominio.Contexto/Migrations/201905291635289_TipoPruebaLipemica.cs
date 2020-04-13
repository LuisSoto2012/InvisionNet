namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoPruebaLipemica : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MuestraHemolizadaLipemica", "IdTipoPrueba", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.MuestraHemolizadaLipemica", "IdTipoPrueba");
        }
    }
}
