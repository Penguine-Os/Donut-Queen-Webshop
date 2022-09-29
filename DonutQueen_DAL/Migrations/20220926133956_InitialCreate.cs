using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonutQueen_DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Glazuur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulling = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Winkels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Nummer = table.Column<int>(type: "int", nullable: false),
                    Postcode = table.Column<int>(type: "int", nullable: false),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winkels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donuts");

            migrationBuilder.DropTable(
                name: "Winkels");
        }
    }
}
