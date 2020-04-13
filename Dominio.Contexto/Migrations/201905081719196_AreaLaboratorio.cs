namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreaLaboratorio : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AreaLaboratorio",
            //    c => new
            //        {
            //            IdAreaLaboratorio = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(nullable: false, maxLength: 200),
            //            Codigo = c.String(maxLength: 5),
            //            PocosFrecuentes = c.Boolean(nullable: false),
            //            Ups = c.Boolean(nullable: false),
            //            Calibracion = c.Boolean(nullable: false),
            //            SueroReferencia = c.Boolean(nullable: false),
            //            NoCalibrado = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdAreaLaboratorio);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.AreaLaboratorio");
        }
    }
}
