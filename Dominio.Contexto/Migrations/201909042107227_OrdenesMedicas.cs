namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdenesMedicas : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.OrdenesMedicas",
            //    c => new
            //        {
            //            IdOrdenMedica = c.Int(nullable: false, identity: true),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            Fecha = c.DateTime(nullable: false),
            //            IdTipoOrdenMedica = c.Int(nullable: false),
            //            IdProcedimiento = c.Int(nullable: false),
            //            TipoAnestesia = c.Int(nullable: false),
            //            TipoUsuario = c.Int(nullable: false),
            //            TipoOjo = c.Int(nullable: false),
            //            TipoEcografia = c.Int(nullable: false),
            //            TipoErg = c.Int(nullable: false),
            //            Descripcion = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdOrdenMedica)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.TipoAnestesia)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.TipoEcografia)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.TipoErg)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.TipoOjo)
            //    .ForeignKey("dbo.Procedimiento", t => t.IdProcedimiento, cascadeDelete: true)
            //    .ForeignKey("dbo.TipoOrdenMedica", t => t.IdTipoOrdenMedica, cascadeDelete: true)
            //    .ForeignKey("dbo.OpcionesOrdenMedica", t => t.TipoUsuario)
            //    .Index(t => t.IdTipoOrdenMedica)
            //    .Index(t => t.IdProcedimiento)
            //    .Index(t => t.TipoAnestesia)
            //    .Index(t => t.TipoUsuario)
            //    .Index(t => t.TipoOjo)
            //    .Index(t => t.TipoEcografia)
            //    .Index(t => t.TipoErg);
            
            //CreateTable(
            //    "dbo.OpcionesOrdenMedica",
            //    c => new
            //        {
            //            IdOpcionOrdenMedica = c.Int(nullable: false, identity: true),
            //            Descripcion = c.String(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdOpcionOrdenMedica);
            
            //CreateTable(
            //    "dbo.TipoOrdenMedica",
            //    c => new
            //        {
            //            IdTipoOrdenMedica = c.Int(nullable: false, identity: true),
            //            Descripcion = c.String(nullable: false, maxLength: 100),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTipoOrdenMedica);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.OrdenesMedicas", "TipoUsuario", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "IdProcedimiento", "dbo.Procedimiento");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoOjo", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoErg", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoEcografia", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoAnestesia", "dbo.OpcionesOrdenMedica");
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoErg" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoEcografia" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoOjo" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoUsuario" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoAnestesia" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdProcedimiento" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdTipoOrdenMedica" });
            //DropTable("dbo.TipoOrdenMedica");
            //DropTable("dbo.OpcionesOrdenMedica");
            //DropTable("dbo.OrdenesMedicas");
        }
    }
}
