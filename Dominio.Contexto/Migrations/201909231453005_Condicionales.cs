namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Condicionales : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.TipoOrdenMedicaRangos", "Condicionales", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.TipoOrdenMedicaRangos", "Condicionales", c => c.String(maxLength: 20));
        }
    }
}
