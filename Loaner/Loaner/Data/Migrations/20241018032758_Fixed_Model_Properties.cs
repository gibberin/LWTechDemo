using Microsoft.EntityFrameworkCore.Migrations;

namespace Loaner.Data.Migrations
{
    public partial class Fixed_Model_Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Size",
                table: "Items",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "Items",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Items");
        }
    }
}
