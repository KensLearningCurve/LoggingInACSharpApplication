using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoggingExample.Business.LoggingExample.Business.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2001, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shrek" },
                    { 2, 3, new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 3, 4, new DateTime(1999, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 4, 5, new DateTime(1968, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Top Gun" },
                    { 5, 5, new DateTime(2011, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puss in Boots" },
                    { 6, 5, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puss in Boots: The Last Wish" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
