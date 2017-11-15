using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProyectoClinica.Datos.Models;

namespace ProyectoClinica.Datos.Migrations
{
    [DbContext(typeof(DatosDbContext))]
    [Migration("20171111032850_Cargainicial")]
    partial class Cargainicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoClinica.Entidad.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comentario")
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("EscecialidadId");

                    b.Property<bool?>("Estado");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime");

                    b.Property<string>("NumeroColegiatura")
                        .HasColumnType("varchar(20)");

                    b.HasKey("DoctorId");

                    b.HasIndex("DoctorId")
                        .IsUnique();

                    b.HasIndex("EscecialidadId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Especialidad", b =>
                {
                    b.Property<int>("EscecialidadId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Estado");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.HasKey("EscecialidadId")
                        .HasName("XPKEspecialidad");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.HorarioAtencion", b =>
                {
                    b.Property<int>("HoraAtencionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionRango")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Estado");

                    b.HasKey("HoraAtencionId")
                        .HasName("XPKHorarioAtencion");

                    b.ToTable("HorarioAtencion");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.OpcionesPerfil", b =>
                {
                    b.Property<int>("OpcionPorPerfilId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OpcionId");

                    b.Property<int?>("PerfilId");

                    b.HasKey("OpcionPorPerfilId")
                        .HasName("XPKOpcionesPerfil");

                    b.HasIndex("OpcionId");

                    b.HasIndex("PerfilId");

                    b.ToTable("OpcionesPerfil");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.OpcionSistema", b =>
                {
                    b.Property<int>("OpcionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionOpcion")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Estado");

                    b.Property<string>("SubTipoOpcion")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TipoOpcion")
                        .HasColumnType("varchar(20)");

                    b.HasKey("OpcionId")
                        .HasName("XPKOpcionSistema");

                    b.ToTable("OpcionSistema");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Paciente", b =>
                {
                    b.Property<int>("PersonaId");

                    b.Property<DateTime?>("FechaUltimaVisita")
                        .HasColumnType("datetime");

                    b.Property<string>("Observacion")
                        .HasColumnType("varchar(200)");

                    b.HasKey("PersonaId")
                        .HasName("XPKPaciente");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.PerfilesSistema", b =>
                {
                    b.Property<int>("PerfilId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Estado");

                    b.HasKey("PerfilId")
                        .HasName("XPKPerfilesSistema");

                    b.ToTable("PerfilesSistema");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("Estado");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NroDocumento")
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("TipoDocumentoId");

                    b.HasKey("PersonaId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.ProgramaAtencion", b =>
                {
                    b.Property<int>("ProgramaAtencionId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("CitaAtendida");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("DoctorId");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaAtencion")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaDiagnostico")
                        .HasColumnType("datetime");

                    b.Property<int>("HoraAtencionId");

                    b.Property<string>("Observaciones")
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("PersonaId");

                    b.HasKey("ProgramaAtencionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HoraAtencionId");

                    b.HasIndex("PersonaId");

                    b.ToTable("ProgramaAtencion");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.TipoDocumento", b =>
                {
                    b.Property<int>("TipoDocumentoId");

                    b.Property<bool?>("Estado");

                    b.Property<string>("NombreDocumento")
                        .HasColumnType("varchar(50)");

                    b.HasKey("TipoDocumentoId");

                    b.ToTable("TipoDocumento");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Usuarios", b =>
                {
                    b.Property<int>("PersonaId");

                    b.Property<string>("Clave")
                        .HasColumnType("varchar(20)");

                    b.Property<bool?>("Estado");

                    b.Property<DateTime?>("FechaUltimoIngreso")
                        .HasColumnType("datetime");

                    b.Property<int?>("PerfilId");

                    b.Property<string>("Usuario")
                        .HasColumnType("varchar(20)");

                    b.HasKey("PersonaId")
                        .HasName("XPKUsuarios");

                    b.HasIndex("PerfilId");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Doctor", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.Persona", "DoctorNavigation")
                        .WithOne("Doctor")
                        .HasForeignKey("ProyectoClinica.Entidad.Doctor", "DoctorId")
                        .HasConstraintName("R_4");

                    b.HasOne("ProyectoClinica.Entidad.Especialidad", "Escecialidad")
                        .WithMany("Doctor")
                        .HasForeignKey("EscecialidadId");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.OpcionesPerfil", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.OpcionSistema", "Opcion")
                        .WithMany("OpcionesPerfil")
                        .HasForeignKey("OpcionId")
                        .HasConstraintName("R_7");

                    b.HasOne("ProyectoClinica.Entidad.PerfilesSistema", "Perfil")
                        .WithMany("OpcionesPerfil")
                        .HasForeignKey("PerfilId");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Paciente", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.Persona", "Persona")
                        .WithOne("Paciente")
                        .HasForeignKey("ProyectoClinica.Entidad.Paciente", "PersonaId")
                        .HasConstraintName("R_12");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Persona", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.TipoDocumento", "TipoDocumento")
                        .WithMany("Persona")
                        .HasForeignKey("TipoDocumentoId")
                        .HasConstraintName("R_14");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.ProgramaAtencion", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.Doctor", "Doctor")
                        .WithMany("ProgramaAtencion")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("R_3");

                    b.HasOne("ProyectoClinica.Entidad.HorarioAtencion", "HoraAtencion")
                        .WithMany("ProgramaAtencion")
                        .HasForeignKey("HoraAtencionId")
                        .HasConstraintName("R_2");

                    b.HasOne("ProyectoClinica.Entidad.Paciente", "Persona")
                        .WithMany("ProgramaAtencion")
                        .HasForeignKey("PersonaId")
                        .HasConstraintName("R_11");
                });

            modelBuilder.Entity("ProyectoClinica.Entidad.Usuarios", b =>
                {
                    b.HasOne("ProyectoClinica.Entidad.PerfilesSistema", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilId")
                        .HasConstraintName("R_10");

                    b.HasOne("ProyectoClinica.Entidad.Persona", "Persona")
                        .WithOne("Usuarios")
                        .HasForeignKey("ProyectoClinica.Entidad.Usuarios", "PersonaId")
                        .HasConstraintName("R_13");
                });
        }
    }
}
