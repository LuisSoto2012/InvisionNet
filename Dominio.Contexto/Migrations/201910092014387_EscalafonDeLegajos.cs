namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EscalafonDeLegajos : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.EscalafonDeLegajos",
            //    c => new
            //        {
            //            IdEscalafonDeLegajos = c.Int(nullable: false, identity: true),
            //            Codigo = c.String(nullable: false, maxLength: 3),
            //            Descripcion = c.String(nullable: false, maxLength: 100),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdEscalafonDeLegajos);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.EscalafonDeLegajos");
        }
    }
}
