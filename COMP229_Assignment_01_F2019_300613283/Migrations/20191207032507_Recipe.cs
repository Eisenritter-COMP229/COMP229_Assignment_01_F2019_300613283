using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP229_Assignment_01_F2019_300613283.Migrations
{
    public partial class Recipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfServings",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrepTime",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalTime",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfServings",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PrepTime",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "Recipes");
        }
    }
}
