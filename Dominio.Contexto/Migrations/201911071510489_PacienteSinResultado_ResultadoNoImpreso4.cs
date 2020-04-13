namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoImpreso4 : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "dbo.EquipoMalCalibrado", name: "AreaLaboratorio_IdAreaLaboratorio", newName: "IdAreaLaboratorio");
            //AddColumn("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", c => c.Int(nullable: false));
            //CreateIndex("dbo.EquipoMalCalibrado", "IdAreaLaboratorio");
            //AddForeignKey("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio", cascadeDelete: true);
        }
        
        public override void Down()
        {
        }
    }
}
