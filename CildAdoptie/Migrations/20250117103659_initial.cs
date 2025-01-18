using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CildAdoptie.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdoptionRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AdoptionRequests",
                columns: new[] { "Id", "ApplicantName", "ChildId", "ContactInfo" },
                values: new object[,]
                {
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e6"), "John Doe", new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e1"), "johndoe@example.com" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e7"), "Jane Smith", new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e2"), "janesmith@example.com" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e8"), "Michael Brown", new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e3"), "michaelbrown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "Age", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e1"), 4, "Loves painting and playing outdoors.", "Female", "Anna" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e2"), 6, "Enjoys puzzles and building blocks.", "Male", "Liam" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e3"), 3, "Very curious and loves to read stories.", "Female", "Sophia" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e4"), 5, "Passionate about soccer and animals.", "Male", "Noah" },
                    { new Guid("7ffa16b3-51ed-4e80-97b6-08dd1f8677e5"), 7, "Loves music and dancing.", "Female", "Emma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionRequests");

            migrationBuilder.DropTable(
                name: "Children");
        }
    }
}
