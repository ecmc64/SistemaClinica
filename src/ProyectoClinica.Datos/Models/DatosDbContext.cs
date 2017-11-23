using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoClinica.Entidad;

namespace ProyectoClinica.Datos.Models
{
    public partial class DatosDbContext : DbContext
    {
        public DatosDbContext(DbContextOptions<DatosDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId).ValueGeneratedOnAdd();

                entity.Property(e => e.Comentario).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.NumeroColegiatura).HasColumnType("varchar(20)");

                entity.HasOne(d => d.DoctorNavigation)
                    .WithOne(p => p.Doctor)
                    .HasForeignKey<Doctor>(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("R_4");

                entity.HasOne(d => d.Escecialidad)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.EscecialidadId)
                    .HasConstraintName("R_1");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.EspecialidadId)
                    .HasName("XPKEspecialidad");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<HorarioAtencion>(entity =>
            {
                entity.HasKey(e => e.HoraAtencionId)
                    .HasName("XPKHorarioAtencion");

                entity.Property(e => e.DescripcionRango).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OpcionSistema>(entity =>
            {
                entity.HasKey(e => e.OpcionId)
                    .HasName("XPKOpcionSistema");

                entity.Property(e => e.DescripcionOpcion).HasColumnType("varchar(50)");

                entity.Property(e => e.SubTipoOpcion).HasColumnType("varchar(20)");

                entity.Property(e => e.TipoOpcion).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<OpcionesPerfil>(entity =>
            {
                entity.HasKey(e => e.OpcionPorPerfilId)
                    .HasName("XPKOpcionesPerfil");

                entity.HasOne(d => d.Opcion)
                    .WithMany(p => p.OpcionesPerfil)
                    .HasForeignKey(d => d.OpcionId)
                    .HasConstraintName("R_7");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.OpcionesPerfil)
                    .HasForeignKey(d => d.PerfilId)
                    .HasConstraintName("R_8");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.PersonaId)
                    .HasName("XPKPaciente");

                entity.Property(e => e.PersonaId).ValueGeneratedNever();

                entity.Property(e => e.FechaUltimaVisita).HasColumnType("datetime");

                entity.Property(e => e.Observacion).HasColumnType("varchar(200)");

                entity.HasOne(d => d.Persona)
                    .WithOne(p => p.Paciente)
                    .HasForeignKey<Paciente>(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("R_12");
            });

            modelBuilder.Entity<PerfilesSistema>(entity =>
            {
                entity.HasKey(e => e.PerfilId)
                    .HasName("XPKPerfilesSistema");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.ApellidoMaterno).HasColumnType("varchar(50)");

                entity.Property(e => e.ApellidoPaterno).HasColumnType("varchar(50)");

                entity.Property(e => e.Direccion).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nombres).HasColumnType("varchar(50)");

                entity.Property(e => e.NroDocumento).HasColumnType("varchar(20)");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .HasConstraintName("R_14");
            });

            modelBuilder.Entity<ProgramaAtencion>(entity =>
            {
                entity.Property(e => e.Diagnostico).HasColumnType("varchar(200)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAtencion).HasColumnType("datetime");

                entity.Property(e => e.FechaDiagnostico).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(200)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ProgramaAtencion)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("R_3");

                entity.HasOne(d => d.HoraAtencion)
                    .WithMany(p => p.ProgramaAtencion)
                    .HasForeignKey(d => d.HoraAtencionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("R_2");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.ProgramaAtencion)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("R_11");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.Property(e => e.TipoDocumentoId).ValueGeneratedNever();

                entity.Property(e => e.NombreDocumento).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.PersonaId)
                    .HasName("XPKUsuarios");

                entity.Property(e => e.PersonaId).ValueGeneratedNever();

                entity.Property(e => e.Clave).HasColumnType("varchar(20)");

                entity.Property(e => e.FechaUltimoIngreso).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.PerfilId)
                    .HasConstraintName("R_10");

                entity.HasOne(d => d.Persona)
                    .WithOne(p => p.Usuarios)
                    .HasForeignKey<Usuarios>(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("R_13");
            });
        }

        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<HorarioAtencion> HorarioAtencion { get; set; }
        public virtual DbSet<OpcionSistema> OpcionSistema { get; set; }
        public virtual DbSet<OpcionesPerfil> OpcionesPerfil { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<PerfilesSistema> PerfilesSistema { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<ProgramaAtencion> ProgramaAtencion { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}