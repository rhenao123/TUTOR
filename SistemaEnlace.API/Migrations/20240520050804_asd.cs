using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
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
                name: "IdJoven",
                table: "conversacions");

            migrationBuilder.DropColumn(
                name: "IdTutor",
                table: "conversacions");

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

            migrationBuilder.AlterColumn<int>(
                name: "supervisorsid",
                table: "formularios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Resumen",
                table: "formularios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "FK_formularios_supervisors_supervisorsid",
                table: "formularios",
                column: "supervisorsid",
                principalTable: "supervisors",
                principalColumn: "id");
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
                name: "FK_formularios_supervisors_supervisorsid",
                table: "formularios");

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

            migrationBuilder.AlterColumn<int>(
                name: "supervisorsid",
                table: "formularios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
