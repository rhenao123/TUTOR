using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    /// <inheritdoc />
    public partial class u : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conversacions_JovenesVulnerables_jovenVulnerablesid",
                table: "conversacions");

            migrationBuilder.DropForeignKey(
                name: "FK_conversacions_Tutores_tutorsid",
                table: "conversacions");

            migrationBuilder.DropForeignKey(
                name: "FK_formularios_supervisors_supervisorsid",
                table: "formularios");

            migrationBuilder.DropColumn(
                name: "IdSupervisor",
                table: "formularios");

            migrationBuilder.DropColumn(
                name: "IdJoven",
                table: "conversacions");

            migrationBuilder.DropColumn(
                name: "IdTutor",
                table: "conversacions");

            migrationBuilder.RenameColumn(
                name: "supervisorsid",
                table: "formularios",
                newName: "Supervisorid");

            migrationBuilder.RenameColumn(
                name: "Idfundacion",
                table: "formularios",
                newName: "Fundacionid");

            migrationBuilder.RenameColumn(
                name: "Idconversacion",
                table: "formularios",
                newName: "Conversacionid");

            migrationBuilder.RenameIndex(
                name: "IX_formularios_supervisorsid",
                table: "formularios",
                newName: "IX_formularios_Supervisorid");

            migrationBuilder.RenameColumn(
                name: "tutorsid",
                table: "conversacions",
                newName: "Tutorid");

            migrationBuilder.RenameColumn(
                name: "jovenVulnerablesid",
                table: "conversacions",
                newName: "JovenVulnerableid");

            migrationBuilder.RenameIndex(
                name: "IX_conversacions_tutorsid",
                table: "conversacions",
                newName: "IX_conversacions_Tutorid");

            migrationBuilder.RenameIndex(
                name: "IX_conversacions_jovenVulnerablesid",
                table: "conversacions",
                newName: "IX_conversacions_JovenVulnerableid");

            migrationBuilder.AlterColumn<string>(
                name: "Resumen",
                table: "formularios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_Conversacionid",
                table: "formularios",
                column: "Conversacionid");

            migrationBuilder.CreateIndex(
                name: "IX_formularios_Fundacionid",
                table: "formularios",
                column: "Fundacionid");

            migrationBuilder.AddForeignKey(
                name: "FK_conversacions_JovenesVulnerables_JovenVulnerableid",
                table: "conversacions",
                column: "JovenVulnerableid",
                principalTable: "JovenesVulnerables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_conversacions_Tutores_Tutorid",
                table: "conversacions",
                column: "Tutorid",
                principalTable: "Tutores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_formularios_conversacions_Conversacionid",
                table: "formularios",
                column: "Conversacionid",
                principalTable: "conversacions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_formularios_fundacions_Fundacionid",
                table: "formularios",
                column: "Fundacionid",
                principalTable: "fundacions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_formularios_supervisors_Supervisorid",
                table: "formularios",
                column: "Supervisorid",
                principalTable: "supervisors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conversacions_JovenesVulnerables_JovenVulnerableid",
                table: "conversacions");

            migrationBuilder.DropForeignKey(
                name: "FK_conversacions_Tutores_Tutorid",
                table: "conversacions");

            migrationBuilder.DropForeignKey(
                name: "FK_formularios_conversacions_Conversacionid",
                table: "formularios");

            migrationBuilder.DropForeignKey(
                name: "FK_formularios_fundacions_Fundacionid",
                table: "formularios");

            migrationBuilder.DropForeignKey(
                name: "FK_formularios_supervisors_Supervisorid",
                table: "formularios");

            migrationBuilder.DropIndex(
                name: "IX_formularios_Conversacionid",
                table: "formularios");

            migrationBuilder.DropIndex(
                name: "IX_formularios_Fundacionid",
                table: "formularios");

            migrationBuilder.RenameColumn(
                name: "Supervisorid",
                table: "formularios",
                newName: "supervisorsid");

            migrationBuilder.RenameColumn(
                name: "Fundacionid",
                table: "formularios",
                newName: "Idfundacion");

            migrationBuilder.RenameColumn(
                name: "Conversacionid",
                table: "formularios",
                newName: "Idconversacion");

            migrationBuilder.RenameIndex(
                name: "IX_formularios_Supervisorid",
                table: "formularios",
                newName: "IX_formularios_supervisorsid");

            migrationBuilder.RenameColumn(
                name: "Tutorid",
                table: "conversacions",
                newName: "tutorsid");

            migrationBuilder.RenameColumn(
                name: "JovenVulnerableid",
                table: "conversacions",
                newName: "jovenVulnerablesid");

            migrationBuilder.RenameIndex(
                name: "IX_conversacions_Tutorid",
                table: "conversacions",
                newName: "IX_conversacions_tutorsid");

            migrationBuilder.RenameIndex(
                name: "IX_conversacions_JovenVulnerableid",
                table: "conversacions",
                newName: "IX_conversacions_jovenVulnerablesid");

            migrationBuilder.AlterColumn<string>(
                name: "Resumen",
                table: "formularios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSupervisor",
                table: "formularios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdJoven",
                table: "conversacions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTutor",
                table: "conversacions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_conversacions_JovenesVulnerables_jovenVulnerablesid",
                table: "conversacions",
                column: "jovenVulnerablesid",
                principalTable: "JovenesVulnerables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_conversacions_Tutores_tutorsid",
                table: "conversacions",
                column: "tutorsid",
                principalTable: "Tutores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_formularios_supervisors_supervisorsid",
                table: "formularios",
                column: "supervisorsid",
                principalTable: "supervisors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
