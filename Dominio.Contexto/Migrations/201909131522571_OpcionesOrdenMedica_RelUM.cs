namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpcionesOrdenMedica_RelUM : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.OrdenesMedicas", "TipoAnestesia", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoEcografia", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoErg", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoOjo", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "TipoUsuario", "dbo.OpcionesOrdenMedica");
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoAnestesia" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoUsuario" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoOjo" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoEcografia" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "TipoErg" });
            //AddColumn("dbo.OpcionesOrdenMedica", "IdOrdenMedica", c => c.Int(nullable: false));
            //CreateIndex("dbo.OpcionesOrdenMedica", "IdOrdenMedica");
            //AddForeignKey("dbo.OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas", "IdOrdenMedica", cascadeDelete: true);
            //DropColumn("dbo.OrdenesMedicas", "TipoAnestesia");
            //DropColumn("dbo.OrdenesMedicas", "TipoUsuario");
            //DropColumn("dbo.OrdenesMedicas", "TipoOjo");
            //DropColumn("dbo.OrdenesMedicas", "TipoEcografia");
            //DropColumn("dbo.OrdenesMedicas", "TipoErg");
            //DropColumn("dbo.OrdenesMedicas", "TipoPatologia");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.OrdenesMedicas", "TipoPatologia", c => c.String(maxLength: 10));
            //AddColumn("dbo.OrdenesMedicas", "TipoErg", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "TipoEcografia", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "TipoOjo", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "TipoUsuario", c => c.Int(nullable: false));
            //AddColumn("dbo.OrdenesMedicas", "TipoAnestesia", c => c.Int(nullable: false));
            //DropForeignKey("dbo.OpcionesOrdenMedica", "IdOrdenMedica", "dbo.OrdenesMedicas");
            //DropIndex("dbo.OpcionesOrdenMedica", new[] { "IdOrdenMedica" });
            //DropColumn("dbo.OpcionesOrdenMedica", "IdOrdenMedica");
            //CreateIndex("dbo.OrdenesMedicas", "TipoErg");
            //CreateIndex("dbo.OrdenesMedicas", "TipoEcografia");
            //CreateIndex("dbo.OrdenesMedicas", "TipoOjo");
            //CreateIndex("dbo.OrdenesMedicas", "TipoUsuario");
            //CreateIndex("dbo.OrdenesMedicas", "TipoAnestesia");
            //AddForeignKey("dbo.OrdenesMedicas", "TipoUsuario", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //AddForeignKey("dbo.OrdenesMedicas", "TipoOjo", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //AddForeignKey("dbo.OrdenesMedicas", "TipoErg", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //AddForeignKey("dbo.OrdenesMedicas", "TipoEcografia", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
            //AddForeignKey("dbo.OrdenesMedicas", "TipoAnestesia", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica");
        }
    }
}
