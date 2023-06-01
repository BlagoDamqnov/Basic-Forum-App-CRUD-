using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumApp.Data.Models.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 1, "First content today", "First post today!" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 2, "Second content today", "Second post today!" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 3, "Third content today", "Third post today!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
