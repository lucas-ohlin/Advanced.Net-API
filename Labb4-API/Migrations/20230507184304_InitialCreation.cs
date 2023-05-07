using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb4_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinksHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    HobbiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinksHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinksHobbies_Hobbies_HobbiesId",
                        column: x => x.HobbiesId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinksHobbies_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Creating software with computer languages.", "Programming" },
                    { 2, "Racing other people often at 200m races.", "Running" },
                    { 3, "Catch fish's from a body of water.", "Fishing" },
                    { 4, "Building webbsites with virtual lego (html).", "Webbdevelopment" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "Lucas", "123123123" },
                    { 2, "Edvin", "3459128" },
                    { 3, "Emil", "7777777" }
                });

            migrationBuilder.InsertData(
                table: "LinksHobbies",
                columns: new[] { "Id", "HobbiesId", "Link", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, "www.github.com", 1 },
                    { 2, 2, "www.github.com/lucas-ohlin", 1 },
                    { 3, 3, "www.lures.com", 2 },
                    { 4, 4, "www.w3schools.com", 2 },
                    { 5, 3, "www.fishing.com", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinksHobbies_HobbiesId",
                table: "LinksHobbies",
                column: "HobbiesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinksHobbies_PersonId",
                table: "LinksHobbies",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinksHobbies");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
