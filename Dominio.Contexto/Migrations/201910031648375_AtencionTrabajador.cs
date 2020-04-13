namespace Dominio.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtencionTrabajador : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AtencionTrabajador",
            //    c => new
            //        {
            //            IdAtencionTrabajador = c.Int(nullable: false, identity: true),
            //            TipoAtencion = c.String(nullable: false, maxLength: 50),
            //            HistoriaClinica = c.String(nullable: false, maxLength: 10),
            //            NumeroDocumento = c.String(maxLength: 10),
            //            Paciente = c.String(nullable: false, maxLength: 500),
            //            Presion = c.Int(),
            //            Temperatura = c.Int(),
            //            Peso = c.Int(),
            //            Talla = c.Int(),
            //            Pulso = c.Int(),
            //            Motivo = c.String(),
            //            CantidadDias = c.Int(),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IdAtencionTrabajador);
            
            //CreateTable(
            //    "dbo.AtencionTrabajador_Diagnostico",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            IdAtencionTrabajador = c.Int(nullable: false),
            //            IdDiagnostico = c.Int(nullable: false),
            //            TipoDiagnostico = c.String(nullable: false, maxLength: 20),
            //            IdUsuarioCreacion = c.Int(nullable: false),
            //            IdUsuarioModificacion = c.Int(),
            //            FechaCreacion = c.DateTime(nullable: false),
            //            FechaModificacion = c.DateTime(),
            //            EsActivo = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AtencionTrabajador", t => t.IdAtencionTrabajador, cascadeDelete: true)
            //    .Index(t => t.IdAtencionTrabajador);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.AtencionTrabajador_Diagnostico", "IdAtencionTrabajador", "dbo.AtencionTrabajador");
            //DropIndex("dbo.AtencionTrabajador_Diagnostico", new[] { "IdAtencionTrabajador" });
            //DropTable("dbo.AtencionTrabajador_Diagnostico");
            //DropTable("dbo.AtencionTrabajador");
        }
    }
}
