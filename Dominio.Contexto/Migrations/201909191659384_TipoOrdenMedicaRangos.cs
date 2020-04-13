namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoOrdenMedicaRangos : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.TipoOrdenMedicaRangos",
            //    c => new
            //        {
            //            IdTipoOrdenMedicaRangos = c.Int(nullable: false, identity: true),
            //            Inicial = c.Int(nullable: false),
            //            Final = c.Int(nullable: false),
            //            Condicionales = c.String(maxLength: 20),
            //            IdTipoOrdenMedica = c.Int(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdTipoOrdenMedicaRangos)
            //    .ForeignKey("dbo.TipoOrdenMedica", t => t.IdTipoOrdenMedica, cascadeDelete: true)
            //    .Index(t => t.IdTipoOrdenMedica);
            
            //DropColumn("dbo.TipoOrdenMedica", "Indices");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.TipoOrdenMedica", "Indices", c => c.String(maxLength: 20));
            //DropForeignKey("dbo.TipoOrdenMedicaRangos", "IdTipoOrdenMedica", "dbo.TipoOrdenMedica");
            //DropIndex("dbo.TipoOrdenMedicaRangos", new[] { "IdTipoOrdenMedica" });
            //DropTable("dbo.TipoOrdenMedicaRangos");
        }
    }
}
