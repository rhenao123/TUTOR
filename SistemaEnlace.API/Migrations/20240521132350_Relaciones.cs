using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    /// <inheritdoc />
    public partial class Relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fundacionid",
                table: "JovenesVulnerables",
                newName: "FundacionId");

            migrationBuilder.CreateIndex(
                name: "IX_JovenesVulnerables_FundacionId",
                table: "JovenesVulnerables",
                column: "FundacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_JovenesVulnerables_fundacions_FundacionId",
                table: "JovenesVulnerables",
                column: "FundacionId",
                principalTable: "fundacions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JovenesVulnerables_fundacions_FundacionId",
                table: "JovenesVulnerables");

            migrationBuilder.DropIndex(
                name: "IX_JovenesVulnerables_FundacionId",
                table: "JovenesVulnerables");

            migrationBuilder.RenameColumn(
                name: "FundacionId",
                table: "JovenesVulnerables",
                newName: "Fundacionid");
        }
    }
}
