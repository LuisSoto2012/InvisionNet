namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reporte : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Reporte",
            //    c => new
            //        {
            //            IdReporte = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(nullable: false, maxLength: 200),
            //            Ruta = c.String(nullable: false),
            //            Ancho = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdReporte);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Reporte");
        }
    }
}
