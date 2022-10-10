using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonutQueen_DAL.Migrations
{
    public partial class AddLeverancier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leverancier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NaamContactpersoon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoornaamContactpersoon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailadres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Huisnummer = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leverancier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeverancierDonut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonutId = table.Column<int>(type: "int", nullable: false),
                    LeverancierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeverancierDonut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeverancierDonut_Donuts_DonutId",
                        column: x => x.DonutId,
                        principalTable: "Donuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeverancierDonut_Leverancier_LeverancierId",
                        column: x => x.LeverancierId,
                        principalTable: "Leverancier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeverancierDonut_DonutId",
                table: "LeverancierDonut",
                column: "DonutId");

            migrationBuilder.CreateIndex(
                name: "IX_LeverancierDonut_LeverancierId",
                table: "LeverancierDonut",
                column: "LeverancierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeverancierDonut");

            migrationBuilder.DropTable(
                name: "Leverancier");
        }
    }
}
