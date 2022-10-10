using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonutQueen_DAL.Migrations
{
    public partial class addDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeverancierDonut_Leverancier_LeverancierId",
                table: "LeverancierDonut");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leverancier",
                table: "Leverancier");

            migrationBuilder.RenameTable(
                name: "Leverancier",
                newName: "Leveranciers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leveranciers",
                table: "Leveranciers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeverancierDonut_Leveranciers_LeverancierId",
                table: "LeverancierDonut",
                column: "LeverancierId",
                principalTable: "Leveranciers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeverancierDonut_Leveranciers_LeverancierId",
                table: "LeverancierDonut");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leveranciers",
                table: "Leveranciers");

            migrationBuilder.RenameTable(
                name: "Leveranciers",
                newName: "Leverancier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leverancier",
                table: "Leverancier",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeverancierDonut_Leverancier_LeverancierId",
                table: "LeverancierDonut",
                column: "LeverancierId",
                principalTable: "Leverancier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
