namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuitarRelacion : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.OrdenesMedicas", "IdTipoAnestesia", "dbo.OpcionesOrdenMedica");
            //DropForeignKey("dbo.OrdenesMedicas", "IdTipoUsuario", "dbo.OpcionesOrdenMedica");
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdTipoAnestesia" });
            //DropIndex("dbo.OrdenesMedicas", new[] { "IdTipoUsuario" });
        }
        
        public override void Down()
        {
            //CreateIndex("dbo.OrdenesMedicas", "IdTipoUsuario");
            //CreateIndex("dbo.OrdenesMedicas", "IdTipoAnestesia");
            //AddForeignKey("dbo.OrdenesMedicas", "IdTipoUsuario", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica", cascadeDelete: true);
            //AddForeignKey("dbo.OrdenesMedicas", "IdTipoAnestesia", "dbo.OpcionesOrdenMedica", "IdOpcionOrdenMedica", cascadeDelete: true);
        }
    }
}
