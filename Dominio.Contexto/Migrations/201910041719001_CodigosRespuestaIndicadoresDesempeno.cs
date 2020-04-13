namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodigosRespuestaIndicadoresDesempeno : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.CodigosRespuestaIndicadoresDesempeno",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Codigo = c.String(nullable: false, maxLength: 4),
            //            Descripcion = c.String(nullable: false, maxLength: 200),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.CodigosRespuestaIndicadoresDesempeno");
        }
    }
}
