namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Auditoria : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Auditoria",
            //    c => new
            //        {
            //            IdAuditoria = c.Int(nullable: false, identity: true),
            //            Accion = c.String(maxLength: 200),
            //            NombreTabla = c.String(maxLength: 200),
            //            ValoresAntiguos = c.String(),
            //            ValoresNuevos = c.String(),
            //            Fecha = c.DateTime(nullable: false),
            //            IdUsuario = c.Int(nullable: false),
            //            IpLogeuo = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.IdAuditoria);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Auditoria");
        }
    }
}
