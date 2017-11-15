using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoClinica.Datos.Migrations
{
    public partial class Cargainicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    EscecialidadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<bool>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKEspecialidad", x => x.EscecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "HorarioAtencion",
                columns: table => new
                {
                    HoraAtencionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionRango = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKHorarioAtencion", x => x.HoraAtencionId);
                });

            migrationBuilder.CreateTable(
                name: "OpcionSistema",
                columns: table => new
                {
                    OpcionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionOpcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<bool>(nullable: true),
                    SubTipoOpcion = table.Column<string>(type: "varchar(20)", nullable: true),
                    TipoOpcion = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKOpcionSistema", x => x.OpcionId);
                });

            migrationBuilder.CreateTable(
                name: "PerfilesSistema",
                columns: table => new
                {
                    PerfilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKPerfilesSistema", x => x.PerfilId);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: true),
                    NombreDocumento = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "OpcionesPerfil",
                columns: table => new
                {
                    OpcionPorPerfilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OpcionId = table.Column<int>(nullable: true),
                    PerfilId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKOpcionesPerfil", x => x.OpcionPorPerfilId);
                    table.ForeignKey(
                        name: "R_7",
                        column: x => x.OpcionId,
                        principalTable: "OpcionSistema",
                        principalColumn: "OpcionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OpcionesPerfil_PerfilesSistema_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "PerfilesSistema",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidoMaterno = table.Column<string>(type: "varchar(50)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "varchar(50)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(100)", nullable: true),
                    Estado = table.Column<bool>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nombres = table.Column<string>(type: "varchar(50)", nullable: true),
                    NroDocumento = table.Column<string>(type: "varchar(20)", nullable: true),
                    TipoDocumentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                    table.ForeignKey(
                        name: "R_14",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumento",
                        principalColumn: "TipoDocumentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comentario = table.Column<string>(type: "varchar(100)", nullable: true),
                    EscecialidadId = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: true),
                    NumeroColegiatura = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                    table.ForeignKey(
                        name: "R_4",
                        column: x => x.DoctorId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Especialidad_EscecialidadId",
                        column: x => x.EscecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "EscecialidadId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false),
                    FechaUltimaVisita = table.Column<DateTime>(type: "datetime", nullable: true),
                    Observacion = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKPaciente", x => x.PersonaId);
                    table.ForeignKey(
                        name: "R_12",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false),
                    Clave = table.Column<string>(type: "varchar(20)", nullable: true),
                    Estado = table.Column<bool>(nullable: true),
                    FechaUltimoIngreso = table.Column<DateTime>(type: "datetime", nullable: true),
                    PerfilId = table.Column<int>(nullable: true),
                    Usuario = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("XPKUsuarios", x => x.PersonaId);
                    table.ForeignKey(
                        name: "R_10",
                        column: x => x.PerfilId,
                        principalTable: "PerfilesSistema",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "R_13",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramaAtencion",
                columns: table => new
                {
                    ProgramaAtencionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CitaAtendida = table.Column<bool>(nullable: true),
                    Diagnostico = table.Column<string>(type: "varchar(200)", nullable: true),
                    DoctorId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaAtencion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaDiagnostico = table.Column<DateTime>(type: "datetime", nullable: true),
                    HoraAtencionId = table.Column<int>(nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(200)", nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramaAtencion", x => x.ProgramaAtencionId);
                    table.ForeignKey(
                        name: "R_3",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "R_2",
                        column: x => x.HoraAtencionId,
                        principalTable: "HorarioAtencion",
                        principalColumn: "HoraAtencionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "R_11",
                        column: x => x.PersonaId,
                        principalTable: "Paciente",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DoctorId",
                table: "Doctor",
                column: "DoctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_EscecialidadId",
                table: "Doctor",
                column: "EscecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionesPerfil_OpcionId",
                table: "OpcionesPerfil",
                column: "OpcionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionesPerfil_PerfilId",
                table: "OpcionesPerfil",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_PersonaId",
                table: "Paciente",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoDocumentoId",
                table: "Persona",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramaAtencion_DoctorId",
                table: "ProgramaAtencion",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramaAtencion_HoraAtencionId",
                table: "ProgramaAtencion",
                column: "HoraAtencionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramaAtencion_PersonaId",
                table: "ProgramaAtencion",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilId",
                table: "Usuarios",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PersonaId",
                table: "Usuarios",
                column: "PersonaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpcionesPerfil");

            migrationBuilder.DropTable(
                name: "ProgramaAtencion");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "OpcionSistema");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "HorarioAtencion");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "PerfilesSistema");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "TipoDocumento");
        }
    }
}
