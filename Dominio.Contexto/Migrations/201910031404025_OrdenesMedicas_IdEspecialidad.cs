namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdenesMedicas_IdEspecialidad : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.OrdenesMedicas", "IdEspecialidad", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "NombreEspecialidad", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.OrdenesMedicas", "NombreEspecialidad");
            //DropColumn("dbo.OrdenesMedicas", "IdEspecialidad");
        }
    }
}
