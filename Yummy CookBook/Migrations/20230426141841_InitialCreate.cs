using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy_CookBook.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<int>(type: "INTEGER", nullable: false),
                    Difficulty = table.Column<string>(type: "TEXT", nullable: false),
                    NbLikes = table.Column<int>(type: "INTEGER", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: false),
                    Process = table.Column<string>(type: "TEXT", nullable: false),
                    TipsTricks = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
