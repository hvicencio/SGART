namespace SGART.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGsart : DbContext
    {
        public ModelGsart()
            : base("name=ModelGsart")
        {
        }

        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Art> Art { get; set; }
        public virtual DbSet<ArtControlCritico> ArtControlCritico { get; set; }
        public virtual DbSet<ArtMedidaControlCritico> ArtMedidaControlCritico { get; set; }
        public virtual DbSet<ArtPeligro> ArtPeligro { get; set; }
        public virtual DbSet<ArtPreguntaRiesgo> ArtPreguntaRiesgo { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<ControlCritico> ControlCritico { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<MedidaControl> MedidaControl { get; set; }
        public virtual DbSet<MedidaControlCritico> MedidaControlCritico { get; set; }
        public virtual DbSet<Peligro> Peligro { get; set; }
        public virtual DbSet<PreguntaRiesgo> PreguntaRiesgo { get; set; }
        public virtual DbSet<Procedimiento> Procedimiento { get; set; }
        public virtual DbSet<Riesgo> Riesgo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Superintendencia> Superintendencia { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividad>()
                .Property(e => e.DescripcionActividad)
                .IsUnicode(false);

            modelBuilder.Entity<Actividad>()
                .HasMany(e => e.Riesgo)
                .WithRequired(e => e.Actividad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.DescripcionArea)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Art)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Art>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<Art>()
                .Property(e => e.Trabajo)
                .IsUnicode(false);

            modelBuilder.Entity<Art>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Art>()
                .Property(e => e.Realizador)
                .IsUnicode(false);

            modelBuilder.Entity<Art>()
                .Property(e => e.Confirmador)
                .IsUnicode(false);

            modelBuilder.Entity<Art>()
                .HasMany(e => e.ArtControlCritico)
                .WithRequired(e => e.Art)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Art>()
                .HasMany(e => e.ArtMedidaControlCritico)
                .WithRequired(e => e.Art)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Art>()
                .HasMany(e => e.ArtPeligro)
                .WithRequired(e => e.Art)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Art>()
                .HasMany(e => e.ArtPreguntaRiesgo)
                .WithRequired(e => e.Art)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArtControlCritico>()
                .Property(e => e.AplicaEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<ArtControlCritico>()
                .Property(e => e.AplicaSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<ArtPeligro>()
                .Property(e => e.Aplica)
                .IsUnicode(false);

            modelBuilder.Entity<ArtPreguntaRiesgo>()
                .Property(e => e.Respuesta)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.DescripcionCargo)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlCritico>()
                .Property(e => e.TituloControlCritico)
                .IsUnicode(false);

            modelBuilder.Entity<ControlCritico>()
                .Property(e => e.DescripcionControlCritico)
                .IsUnicode(false);

            modelBuilder.Entity<ControlCritico>()
                .Property(e => e.PreguntaVerificacionSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<ControlCritico>()
                .Property(e => e.PreguntaVerificacionEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<ControlCritico>()
                .HasMany(e => e.ArtControlCritico)
                .WithRequired(e => e.ControlCritico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlCritico>()
                .HasMany(e => e.ArtMedidaControlCritico)
                .WithRequired(e => e.ControlCritico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlCritico>()
                .HasMany(e => e.MedidaControlCritico)
                .WithRequired(e => e.ControlCritico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Run)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.DescripcionEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Art)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedidaControl>()
                .Property(e => e.DescripcionMedidaControl)
                .IsUnicode(false);

            modelBuilder.Entity<MedidaControlCritico>()
                .Property(e => e.DescripcionMedidaControlCritico)
                .IsUnicode(false);

            modelBuilder.Entity<MedidaControlCritico>()
                .HasMany(e => e.ArtMedidaControlCritico)
                .WithRequired(e => e.MedidaControlCritico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Peligro>()
                .Property(e => e.DescripcionPeligro)
                .IsUnicode(false);

            modelBuilder.Entity<Peligro>()
                .Property(e => e.Regla)
                .IsUnicode(false);

            modelBuilder.Entity<Peligro>()
                .HasMany(e => e.ArtPeligro)
                .WithRequired(e => e.Peligro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Peligro>()
                .HasMany(e => e.ControlCritico)
                .WithRequired(e => e.Peligro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreguntaRiesgo>()
                .Property(e => e.DescripcionPregunta)
                .IsUnicode(false);

            modelBuilder.Entity<PreguntaRiesgo>()
                .HasMany(e => e.ArtPreguntaRiesgo)
                .WithRequired(e => e.PreguntaRiesgo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.DescripcionProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.Adjunto)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .HasMany(e => e.Actividad)
                .WithRequired(e => e.Procedimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Riesgo>()
                .Property(e => e.DescripcionRiesgo)
                .IsUnicode(false);

            modelBuilder.Entity<Riesgo>()
                .HasMany(e => e.MedidaControl)
                .WithRequired(e => e.Riesgo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.DescripcionRol)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Superintendencia>()
                .Property(e => e.DescripcionSuperintendencia)
                .IsUnicode(false);

            modelBuilder.Entity<Superintendencia>()
                .HasMany(e => e.Art)
                .WithRequired(e => e.Superintendencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .Property(e => e.DescripcionTurno)
                .IsUnicode(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Turno)
                .WillCascadeOnDelete(false);
        }
    }
}
