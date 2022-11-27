using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TSFoodBar.Data.Migrations
{
    public partial class My8thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desserts",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Drinks",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "Starters",
                table: "Menus",
                newName: "FoodType");

            migrationBuilder.RenameColumn(
                name: "Mains",
                table: "Menus",
                newName: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodType",
                table: "Menus",
                newName: "Starters");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Menus",
                newName: "Mains");

            migrationBuilder.AddColumn<string>(
                name: "Desserts",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drinks",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
