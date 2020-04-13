namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComentarioPruebasNoRealizadas : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.PruebasNoRealizadas", "Comentario", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.PruebasNoRealizadas", "Comentario");
        }
    }
}
