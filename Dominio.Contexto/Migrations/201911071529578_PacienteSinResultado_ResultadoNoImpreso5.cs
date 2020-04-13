namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado_ResultadoNoImpreso5 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.EquipoMalCalibrado",
            //    c => new
            //    {
            //        IdEquipoMalCalibrado = c.Int(nullable: false, identity: true),
            //        IdAreaLaboratorio = c.Int(nullable: false),
            //        TotalDeEquipos = c.Int(nullable: false),
            //        NumeroMes = c.Int(nullable: false),
            //        Inadecuados = c.Int(nullable: false),
            //        IdUsuarioCreacion = c.Int(nullable: false),
            //        IdUsuarioModificacion = c.Int(),
            //        FechaCreacion = c.DateTime(nullable: false),
            //        FechaModificacion = c.DateTime(),
            //        EsActivo = c.Boolean(nullable: false),
            //    })
            //    .PrimaryKey(t => t.IdEquipoMalCalibrado)
            //    .ForeignKey("dbo.AreaLaboratorio", t => t.IdAreaLaboratorio, cascadeDelete: true)
            //    .Index(t => t.IdAreaLaboratorio);
        }

        public override void Down()
        {
        }
    }
}
