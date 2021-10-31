using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreIncludeFilter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                column: "Id",
                value: 2);

            migrationBuilder.InsertData(
                table: "Categories",
                column: "Id",
                value: 3);

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CategoryId", "LastUpdate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_CategoryId",
                table: "Records",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
