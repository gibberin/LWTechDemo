using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loaner.Data.Migrations
{
    public partial class Initial_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoanEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    LoanedItemId = table.Column<int>(nullable: true),
                    BorrowerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanEvents_People_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanEvents_Items_LoanedItemId",
                        column: x => x.LoanedItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanEvents_BorrowerId",
                table: "LoanEvents",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanEvents_LoanedItemId",
                table: "LoanEvents",
                column: "LoanedItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanEvents");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
