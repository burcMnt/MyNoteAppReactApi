using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteAppApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreateTime", "ModifiedTime", "Title" },
                values: new object[] { 1, "Lorem ipsum sit amet,consectetur.", new DateTime(2021, 10, 15, 11, 54, 15, 221, DateTimeKind.Local).AddTicks(527), null, "Simple note1" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreateTime", "ModifiedTime", "Title" },
                values: new object[] { 2, "Set et luctus dolor, eget ullacorper urna.", new DateTime(2021, 10, 15, 11, 54, 15, 222, DateTimeKind.Local).AddTicks(3823), null, "Simple note2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
