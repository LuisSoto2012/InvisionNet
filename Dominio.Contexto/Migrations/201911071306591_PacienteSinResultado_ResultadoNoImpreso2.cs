namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoImpreso2 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.EquipoMalCalibrado", "MyProperty", c => c.Int(nullable: false));
            //AddColumn("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio", c => c.Int());
            //CreateIndex("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio");
            //AddForeignKey("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.EquipoMalCalibrado", new[] { "AreaLaboratorio_IdAreaLaboratorio" });
            //DropColumn("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio");
            //DropColumn("dbo.EquipoMalCalibrado", "MyProperty");
        }
    }
}
