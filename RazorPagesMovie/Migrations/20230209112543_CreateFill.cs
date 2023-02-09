using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    public partial class CreateFill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovieAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieAuthor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Email", "Nickname" },
                values: new object[,]
                {
                    { 1, 22, "tt@mail.ru", "Poppy" },
                    { 2, 32, "dthd@mail.ru", "Rob" },
                    { 3, 23, "hgj465@mail.ru", "Al97" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Actions" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Date", "GenreId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1.7m, "The Spirit" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Date", "GenreId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2.4m, "Robot" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Date", "GenreId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5.8m, "Katty in Hollywood" });

            migrationBuilder.InsertData(
                table: "MovieAuthor",
                columns: new[] { "Id", "AuthorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 2 },
                    { 3, 3, 2 },
                    { 4, 1, 1 },
                    { 5, 2, 1 },
                    { 6, 3, 3 },
                    { 7, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAuthor_AuthorId",
                table: "MovieAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAuthor_MovieId",
                table: "MovieAuthor",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieAuthor");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
