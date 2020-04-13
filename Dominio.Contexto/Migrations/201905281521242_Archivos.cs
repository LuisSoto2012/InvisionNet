namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Archivos : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Archivo",
            //    c => new
            //        {
            //            IdArchivo = c.Int(nullable: false, identity: true),
            //            IdEspecialidad = c.Int(nullable: false),
            //            IdServicio = c.Int(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            Ruta = c.String(nullable: false),
            //            NombreArchivo = c.String(nullable: false, maxLength: 200),
            //            RutaCompleta = c.String(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdArchivo);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Archivo");
        }
    }
}
