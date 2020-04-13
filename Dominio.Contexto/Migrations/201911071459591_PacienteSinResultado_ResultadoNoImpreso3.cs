namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoImpreso3 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.EquipoMalCalibrado", new[] { "AreaLaboratorio_IdAreaLaboratorio" });
            //RenameColumn(table: "dbo.EquipoMalCalibrado", name: "AreaLaboratorio_IdAreaLaboratorio", newName: "IdAreaLaboratorio");
            //AlterColumn("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", c => c.Int(nullable: false));
            //CreateIndex("dbo.EquipoMalCalibrado", "IdAreaLaboratorio");
            //AddForeignKey("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio", cascadeDelete: true);
            //DropColumn("dbo.EquipoMalCalibrado", "MyProperty");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.EquipoMalCalibrado", "MyProperty", c => c.Int(nullable: false));
            //DropForeignKey("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", "dbo.AreaLaboratorio");
            //DropIndex("dbo.EquipoMalCalibrado", new[] { "IdAreaLaboratorio" });
            //AlterColumn("dbo.EquipoMalCalibrado", "IdAreaLaboratorio", c => c.Int());
            //RenameColumn(table: "dbo.EquipoMalCalibrado", name: "IdAreaLaboratorio", newName: "AreaLaboratorio_IdAreaLaboratorio");
            //CreateIndex("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio");
            //AddForeignKey("dbo.EquipoMalCalibrado", "AreaLaboratorio_IdAreaLaboratorio", "dbo.AreaLaboratorio", "IdAreaLaboratorio");
        }
    }
}
