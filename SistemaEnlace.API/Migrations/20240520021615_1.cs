using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fundacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fundacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JovenesVulnerables",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Situacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JovenesVulnerables", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "supervisors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Experiencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formularios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idconversacion = table.Column<int>(type: "int", nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supervisorsid = table.Column<int>(type: "int", nullable: false),
                    IdSupervisor = table.Column<int>(type: "int", nullable: false),
                    Idfundacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formularios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formularios_supervisors_supervisorsid",
                        column: x => x.supervisorsid,
                        principalTable: "supervisors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conversacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdJoven = table.Column<int>(type: "int", nullable: false),
                    IdTutor = table.Column<int>(type: "int", nullable: false),
                    jovenVulnerablesid = table.Column<int>(type: "int", nullable: false),
                    tutorsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_conversacions_JovenesVulnerables_jovenVulnerablesid",
                        column: x => x.jovenVulnerablesid,
                        principalTable: "JovenesVulnerables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conversacions_Tutores_tutorsid",
                        column: x => x.tutorsid,
                        principalTable: "Tutores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_Id",
                table: "conversacions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_jovenVulnerablesid",
                table: "conversacions",
                column: "jovenVulnerablesid");

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_tutorsid",
                table: "conversacions",
                column: "tutorsid");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_supervisorsid",
                table: "formularios",
                column: "supervisorsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conversacions");

            migrationBuilder.DropTable(
                name: "formularios");

            migrationBuilder.DropTable(
                name: "fundacions");

            migrationBuilder.DropTable(
                name: "JovenesVulnerables");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropTable(
                name: "supervisors");
        }
    }
}
