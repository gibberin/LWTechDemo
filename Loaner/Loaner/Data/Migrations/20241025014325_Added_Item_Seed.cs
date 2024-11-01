using Microsoft.EntityFrameworkCore.Migrations;

namespace Loaner.Data.Migrations
{
    public partial class Added_Item_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Size", "Value" },
                values: new object[] { 1, "Test Item", 11f, 101f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
