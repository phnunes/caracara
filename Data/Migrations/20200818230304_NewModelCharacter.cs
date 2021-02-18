using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraCara.Data.Migrations
{
    public partial class NewModelCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    HairLength = table.Column<string>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    EyeColor = table.Column<string>(nullable: true),
                    HasGlass = table.Column<bool>(nullable: false),
                    Genre = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chars", x => x.Id);
                });
                 migrationBuilder.InsertData(
                table: "Chars",
                columns: new[] { "Id", "EyeColor", "Genre", "HairColor", "HairLength", "HasGlass", "Name" },
                values: new object[,]
                {
                    { 20, "brown", true, "black", "long", false, "Alice" },
                    { 17, "green", false, "black", "short", false, "Rick" },
                    { 16, "brown", true, "brown", "short", false, "Rachel" },
                    { 15, "brown", false, "brown", "short", false, "Peter" },
                    { 14, "blue", false, "yellow", "long", true, "Paul" },
                    { 13, "blue", true, "yellow", "short", false, "Nancy" },
                    { 12, "green", false, "brown", "short", false, "Mark" },
                    { 11, "green", false, "black", "short", false, "Leo" },
                    { 10, "blue", false, "brown", "short", false, "Sam" },
                    { 9, "blue", true, "brown", "short", false, "Julia" },
                    { 8, "brown", false, "brown", "short", true, "Jhonny" },
                    { 7, "green", true, "black", "short", false, "Kate" },
                    { 6, "green", false, "yellow", "short", false, "Jack" },
                    { 5, "green", true, "brown", "long", true, "Gabriela" },
                    { 4, "brown", false, "black", "short", true, "Eric" },
                    { 3, "green", false, "brown", "long", false, "Dillan" },
                    { 2, "brown", true, "brown", "short", false, "Britney" },
                    { 1, "blue", true, "yellow", "short", false, "Ana" },
                    { 18, "green", false, "brown", "short", true, "Stan" },
                    { 19, "green", true, "brown", "short", false, "Vivian" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chars");
        }
    }
}
