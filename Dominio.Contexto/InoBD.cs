    using Dominio.Entidades;
using Dominio.Entidades.Comunes;
using Dominio.Entidades.LaboratorioInmunologico;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dominio.Contexto
{
    public class InoBD : DbContext
    {
        public DbSet<Aplicacion> Aplicaciones { set; get; }
        public DbSet<Empleado> Empleados { set; get; }
        public DbSet<Rol> Roles { set; get; }
        public DbSet<Modulo> Modulo { set; get; }
        public DbSet<SubModulo> SubModulo { set; get; }
        public DbSet<RolSubModulo> RolSubModulo { set; get; }
        public DbSet<CondicionTrabajo> CondicionTrabajo { set; get; }
        public DbSet<TipoEmpleado> TipoEmpleado { set; get; }
        public DbSet<TipoDocumentoIdentidad> TipoDocumentoIdentidad { set; get; }
        public DbSet<RecoleccionMuestra> RecoleccionMuestra { set; get; }
        public DbSet<VenopunturasFallidas> VenopunturasFallidas { set; get; }
        public DbSet<IncidentesPacientes> IncidentesPacientes { set; get; }
        public DbSet<IncumplimientoAnalisis> IncumplimientoAnalisis { set; get; }
        public DbSet<PruebasNoRealizadas> PruebasNoRealizadas { set; get; }
        public DbSet<AreaLaboratorio> AreaLaboratorio { set; get; }
        public DbSet<CalibracionDeficiente> CalibracionDeficiente { set; get; }
        public DbSet<EmpleoReactivo> EmpleoReactivo { set; get; }
        public DbSet<EquipoMalCalibrado> EquipoMalCalibrado { set; get; }
        public DbSet<EquipoUPS> EquipoUPS { set; get; }
        public DbSet<MaterialNoCalibrado> MaterialNoCalibrado { set; get; }
        public DbSet<MuestraHemolizadaLipemica> MuestraHemolizadaLipemica { set; get; }
        public DbSet<PocoFrecuente> PocoFrecuente { set; get; }
        public DbSet<SueroMalReferenciado> SueroMalReferenciado { set; get; }
        public DbSet<TranscripcionErroneaInoportuna> TranscripcionErroneaInoportuna { set; get; }
        public DbSet<TranscripcionErronea> TranscripcionErronea { set; get; }
        public DbSet<SolicitudDatosIncompletos> SolicitudDatosIncompletos { set; get; }
        public DbSet<RendimientoHoraTrabajador> RendimientoHoraTrabajador { set; get; }
        public DbSet<PacienteSinResultado> PacienteSinResultado { set; get; }
        public DbSet<Reporte> Reporte { set; get; }
        public DbSet<Archivo> Archivos { set; get; }
        public DbSet<Auditoria> Auditoria { set; get; }
        public DbSet<TicketConsultaExterna> TicketConsultaExterna { set; get; }
        public DbSet<Procedimiento> Procedimiento { set; get; }
        public DbSet<OrdenesMedicas> OrdenesMedicas{ set; get; }
        public DbSet<OrdenesMedicasCodigos> OrdenesMedicasCodigos { set; get; }
        public DbSet<TipoOrdenMedica> TipoOrdenMedica { set; get; }
        public DbSet<OpcionesOrdenMedica> OpcionesOrdenMedica { set; get; }
        public DbSet<TipoOrdenMedica_Procedimiento> TipoOrdenMedica_Procedimiento { set; get; }
        public DbSet<AtencionTrabajador> AtencionTrabajador { set; get; }
        public DbSet<AtencionTrabajador_Diagnostico> AtencionTrabajador_Diagnostico { set; get; }
        public DbSet<CodigosRespuestaIndicadoresDesempeno> CodigosRespuestaIndicadoresDesempeno { set; get; }
        public DbSet<EscalafonDeLegajos> EscalafonDeLegajos { set; get; }

        public InoBD() : base("InoBD") {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            //AplicacionEmpleado (Relacion muchos a muchos)
            modelBuilder.Entity<Empleado>()
                .HasMany<Aplicacion>(a => a.Aplicaciones)
                .WithMany(e => e.Empleado)
                .Map(ae =>
                {
                    ae.MapLeftKey("IdEmpleado");
                    ae.MapRightKey("IdAplicacion");
                    ae.ToTable("AplicacionEmpleado");
                });

            //UsuarioRol
            modelBuilder.Entity<Empleado>()
                .HasMany<Rol>(u => u.Roles)
                .WithMany(r => r.Empleado)
                .Map(cs =>
                {
                    cs.MapLeftKey("IdEmpleado");
                    cs.MapRightKey("IdRol");
                    cs.ToTable("UsuarioRol");
                });

            //SubModulo (Relacion de uno a muchos)
            modelBuilder.Entity<SubModulo>()
                .HasRequired<Modulo>(s => s.Modulo)
                .WithMany(m => m.SubModulo)
                .HasForeignKey<int>(m => m.IdModulo);

            //Empleado CondicionTrabajo (Relacion de uno a uno - transaccional-maestra)
            modelBuilder.Entity<Empleado>()
                .HasRequired(w => w.CondicionTrabajo)
                .WithMany()
                .HasForeignKey<int>(m => m.IdCondicionTrabajo);

            //Empleado TipoEmpleado
            modelBuilder.Entity<Empleado>()
                .HasRequired(e => e.TipoEmpleado)
                .WithMany()
                .HasForeignKey<int>(m => m.IdTipoEmpleado);

            //Empleado TipoDocumentoIdentidad
            modelBuilder.Entity<Empleado>()
                .HasRequired(e => e.TipoDocumentoIdentidad)
                .WithMany()
                .HasForeignKey<int>(m => m.IdTipoDocumento);

            //PocoFrecuente AreaLaboratorio
            modelBuilder.Entity<PocoFrecuente>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //EquipoUPS AreaLaboratorio
            modelBuilder.Entity<EquipoUPS>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //CalibracionDeficiente AreaLaboratorio
            modelBuilder.Entity<CalibracionDeficiente>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //SueroMalReferenciado AreaLaboratorio
            modelBuilder.Entity<SueroMalReferenciado>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //MaterialNoCalibrado AreaLaboratorio
            modelBuilder.Entity<MaterialNoCalibrado>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //EquipoMalCalibrado AreaLaboratorio
            modelBuilder.Entity<EquipoMalCalibrado>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //MuestraHemolizadaLipemica AreaLaboratorio
            modelBuilder.Entity<MuestraHemolizadaLipemica>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //RendimientoHoraTrabajador AreaLaboratorio
            modelBuilder.Entity<RendimientoHoraTrabajador>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //EmpleoReactivo AreaLaboratorio
            modelBuilder.Entity<EmpleoReactivo>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //TranscripcionErroneaInoportuna AreaLaboratorio
            modelBuilder.Entity<TranscripcionErroneaInoportuna>()
                .HasRequired(e => e.AreaLaboratorio)
                .WithMany()
                .HasForeignKey<int>(m => m.IdAreaLaboratorio);

            //SubModulo-AreaLaboratorio
            modelBuilder.Entity<SubModulo>()
                .HasMany<AreaLaboratorio>(a => a.AreaLaboratorios)
                .WithMany(s => s.SubModulos)
                .Map(ae =>
                {
                    ae.MapLeftKey("IdSubModulo");
                    ae.MapRightKey("IdAreaLaboratorio");
                    ae.ToTable("SubModulo_AreaLaboratorio");
                });

            //SubModulo-Reporte
            modelBuilder.Entity<SubModulo>()
                .HasMany<Reporte>(r => r.Reportes)
                .WithMany(s => s.SubModulos)
                .Map(sr =>
                {
                    sr.MapLeftKey("IdSubModulo");
                    sr.MapRightKey("IdReporte");
                    sr.ToTable("SubModulo_Reporte");
                });
            
            //OrdenesMedicas TipoOrdenMedica
            modelBuilder.Entity<OrdenesMedicas>()
                .HasRequired(e => e.TipoOrdenMedica)
                .WithMany()
                .HasForeignKey<int>(m => m.IdTipoOrdenMedica);
            //OrdenesMedicasCodigos
            modelBuilder.Entity<OrdenesMedicasCodigos>()
                .HasRequired<OrdenesMedicas>(s => s.OrdenesMedicas)
                .WithMany(m => m.OrdenesMedicasCodigos)
                .HasForeignKey<int>(m => m.IdOrdenMedica);
            //OrdenesMedicasCodigos Procedimiento
            modelBuilder.Entity<OrdenesMedicasCodigos>()
                .HasRequired(e => e.Procedimiento)
                .WithMany()
                .HasForeignKey<int>(m => m.IdProcedimiento);
            //OrdenesMedicasCodigos_OpcionesOrdenMedica
            modelBuilder.Entity<OrdenesMedicasCodigos>()
                .HasMany<OpcionesOrdenMedica>(a => a.OpcionesOrdenMedica)
                .WithMany(e => e.OrdenesMedicasCodigos)
                .Map(ae =>
                {
                    ae.MapLeftKey("IdOrdenesMedicasCodigos");
                    ae.MapRightKey("IdOpcionOrdenMedica");
                    ae.ToTable("OrdenesMedicasCodigos_OpcionesOrdenMedica");
                });

            //TipoOrdenMedicaRangos (Relacion de uno a muchos)
            modelBuilder.Entity<TipoOrdenMedicaRangos>()
                .HasRequired<TipoOrdenMedica>(s => s.TipoOrdenMedica)
                .WithMany(m => m.TipoOrdenMedicaRangos)
                .HasForeignKey<int>(m => m.IdTipoOrdenMedica);
        }
    }
}
