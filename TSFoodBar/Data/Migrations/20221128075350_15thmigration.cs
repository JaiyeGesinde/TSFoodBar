using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TSFoodBar.Data.Migrations
{
    public partial class _15thmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "FoodType",
                table: "Menus",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainIngredients",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OptionIngredients",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Menus",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "MainIngredients",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "OptionIngredients",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Menus",
                newName: "FoodType");

            migrationBuilder.AddColumn<string>(
                name: "FoodId",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
