namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relaciones_OrdenesMedicas : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas");
            //DropForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOpcionOrdenMedica", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "IdProcedimiento", "dbo.Procedimiento");
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdProcedimiento" });
            //DropIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", new[] { "IdOrdenMedica" });
            //DropIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", new[] { "IdOpcionOrdenMedica" });
            //CreateTable(
            //    "dbo.OrdenesMedicasCodigos",
            //    c => new
            //        {
            //            IdOrdenesMedicasCodigos = c.Int(nullable: false, identity: true),
            //            IdProcedimiento = c.Int(nullable: false),
            //            Descripcion = c.String(),
            //            IdOrdenMedica = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdOrdenesMedicasCodigos)
            //    .ForeignKey("dbo.OrdenesMedicas", t => t.IdOrdenMedica, cascadeDelete: true)
            //    .ForeignKey("dbo.Procedimiento", t => t.IdProcedimiento, cascadeDelete: true)
            //    .Index(t => t.IdProcedimiento)
            //    .Index(t => t.IdOrdenMedica);
            
            //CreateTable(
            //    "dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica",
            //    c => new
            //        {
            //            IdOrdenesMedicasCodigos = c.Int(nullable: false),
            //            IdOpcionOrdenMedica = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdOrdenesMedicasCodigos, t.IdOpcionOrdenMedica })
            //    .ForeignKey("dbo.OrdenesMedicasCodigos", t => t.IdOrdenesMedicasCodigos, cascadeDelete: true)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.IdOpcionOrdenMedica, cascadeDelete: true)
            //    .Index(t => t.IdOrdenesMedicasCodigos)
            //    .Index(t => t.IdOpcionOrdenMedica);
            
            //AddColumn("dbo.OrdenesMedicas", "IdTipoAnestesia", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "IdTipoUsuario", c => c.Int(nullable: false));
            //CreateIndex("dbo.OrdenesMedicas", "IdTipoAnestesia");
            //CreateIndex("dbo.OrdenesMedicas", "IdTipoUsuario");
            //AddForeignKey("dbo.OrdenesMedicas", "IdTipoAnestesia", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //AddForeignKey("dbo.OrdenesMedicas", "IdTipoUsuario", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //DropColumn("dbo.OrdenesMedicas", "IdProcedimiento");
            //DropColumn("dbo.OrdenesMedicas", "Descripcion");
            //DropTable("dbo.OrdenesMedicas_OpcionesOrdenMedica");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.OrdenesMedicas_OpcionesOrdenMedica",
            //    c => new
            //        {
            //            IdOrdenMedica = c.Int(nullable: false),
            //            IdOpcionOrdenMedica = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.IdOrdenMedica, t.IdOpcionOrdenMedica });
            
            //AddColumn("dbo.OrdenesMedicas", "Descripcion", c => c.String());
            //AddColumn("dbo.OrdenesMedicas", "IdProcedimiento", c => c.Int(nullable: false));
            //DropForeignKey("dbo.OrdenesMedicasCodigos", "IdProcedimiento", "dbo.Procedimiento");
            //DropForeignKey("dbo.OrdenesMedicasCodigos", "IdOrdenMedica", "dbo.OrdenesMedicas");
            //DropForeignKey("dbo.OrdenesMedicas", "IdTipoUsuario", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "IdTipoAnestesia", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica", "IdOpcionOrdenMedica", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica", "IdOrdenesMedicasCodigos", "dbo.OrdenesMedicasCodigos");
            //DropIndex("dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica", new[] { "IdOpcionOrdenMedica" });
            //DropIndex("dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica", new[] { "IdOrdenesMedicasCodigos" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdTipoUsuario" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdTipoAnestesia" });
            //DropIndex("dbo.OrdenesMedicasCodigos", new[] { "IdOrdenMedica" });
            //DropIndex("dbo.OrdenesMedicasCodigos", new[] { "IdProcedimiento" });
            //DropColumn("dbo.OrdenesMedicas", "IdTipoUsuario");
            //DropColumn("dbo.OrdenesMedicas", "IdTipoAnestesia");
            //DropTable("dbo.OrdenesMedicasCodigos_OpcionesOrdenMedica");
            //DropTable("dbo.OrdenesMedicasCodigos");
            //CreateIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //CreateIndex("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOrdenMedica");
            //CreateIndex("dbo.OrdenesMedicas", "IdProcedimiento");
            //AddForeignKey("dbo.OrdenesMedicas", "IdProcedimiento", "dbo.Procedimiento", "IdProcedimiento", cascadeDelete: true);
            //AddForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOpcionOrdenMedica", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica", cascadeDelete: true);
            //AddForeignKey("dbo.OrdenesMedicas_OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas", "IdOrdenMedica", cascadeDelete: true);
        }
    }
}
