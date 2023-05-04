using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb4_Advanced_API.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LinksIntrests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    InterestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinksIntrests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LinksIntrests_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinksIntrests_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "ID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "A MMO game", "WoW" },
                    { 2, "coding", "Coding" },
                    { 3, "fishing", "Fishing" },
                    { 4, "A sport", "Football" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Emil", "123456789" },
                    { 2, "Isak", "987654321" },
                    { 3, "Lucas", "000000000" }
                });

            migrationBuilder.InsertData(
                table: "LinksIntrests",
                columns: new[] { "ID", "InterestsId", "Link", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, "www.wowhead.com", 1 },
                    { 2, 1, "www.worldofwarcraft.blizzardcom", 1 },
                    { 3, 2, "www.learn.microsoft.com", 1 },
                    { 4, 3, "www.fiske.se", 1 },
                    { 5, 2, "www.Github.com", 2 },
                    { 6, 2, "www.github.com", 3 },
                    { 7, 4, "www.wikipedia/foorball.com", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinksIntrests_InterestsId",
                table: "LinksIntrests",
                column: "InterestsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinksIntrests_PersonId",
                table: "LinksIntrests",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinksIntrests");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
