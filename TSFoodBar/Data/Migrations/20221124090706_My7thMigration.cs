using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TSFoodBar.Data.Migrations
{
    public partial class My7thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mains = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desserts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drinks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
