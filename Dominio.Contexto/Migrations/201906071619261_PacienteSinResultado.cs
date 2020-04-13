namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteSinResultado : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.PacienteSinResultado",
            //    c => new
            //        {
            //            IdPacienteSinResultado = c.Int(nullable: false, identity: true),
            //            FechaOcurrencia = c.DateTime(nullable: false),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            MuestraNoTomada = c.Boolean(nullable: false),
            //            ResultadoNoIngresado = c.Boolean(nullable: false),
            //            PruebaNoRegistrada = c.Boolean(nullable: false),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdPacienteSinResultado);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.PacienteSinResultado");
        }
    }
}
