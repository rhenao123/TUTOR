using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
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
                    Situacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fundacionid = table.Column<int>(type: "int", nullable: false)
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
                name: "conversacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JovenVulnerableid = table.Column<int>(type: "int", nullable: false),
                    Tutorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_conversacions_JovenesVulnerables_JovenVulnerableid",
                        column: x => x.JovenVulnerableid,
                        principalTable: "JovenesVulnerables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conversacions_Tutores_Tutorid",
                        column: x => x.Tutorid,
                        principalTable: "Tutores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formularios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conversacionid = table.Column<int>(type: "int", nullable: false),
                    Supervisorid = table.Column<int>(type: "int", nullable: false),
                    Fundacionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formularios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formularios_conversacions_Conversacionid",
                        column: x => x.Conversacionid,
                        principalTable: "conversacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formularios_fundacions_Fundacionid",
                        column: x => x.Fundacionid,
                        principalTable: "fundacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formularios_supervisors_Supervisorid",
                        column: x => x.Supervisorid,
                        principalTable: "supervisors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_Id",
                table: "conversacions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_JovenVulnerableid",
                table: "conversacions",
                column: "JovenVulnerableid");

            migrationBuilder.CreateIndex(
                name: "IX_conversacions_Tutorid",
                table: "conversacions",
                column: "Tutorid");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_Conversacionid",
                table: "formularios",
                column: "Conversacionid");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_Fundacionid",
                table: "formularios",
                column: "Fundacionid");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_Supervisorid",
                table: "formularios",
                column: "Supervisorid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formularios");

            migrationBuilder.DropTable(
                name: "conversacions");

            migrationBuilder.DropTable(
                name: "fundacions");

            migrationBuilder.DropTable(
                name: "supervisors");

            migrationBuilder.DropTable(
                name: "JovenesVulnerables");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}
