namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedimiento : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Procedimiento",
            //    c => new
            //        {
            //            IdProcedimiento = c.Int(nullable: false, identity: true),
            //            Codigo = c.String(nullable: false, maxLength: 20),
            //            Descripcion = c.String(nullable: false),
            //            IdEspecialidad = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdProcedimiento);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Procedimiento");
        }
    }
}
