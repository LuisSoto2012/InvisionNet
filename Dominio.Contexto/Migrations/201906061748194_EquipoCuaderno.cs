namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipoCuaderno : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TranscripcionErroneaInoportuna", "EquipoCuaderno", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.TranscripcionErroneaInoportuna", "EquipoCuaderno");
        }
    }
}
