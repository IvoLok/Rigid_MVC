using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rigid.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductToDbAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Fortune of Time, vitae euismod velit sollicitudin ac. Fortune of Time nibh ut ultricies.\r\n\r\nNunc Fortune of Time ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Hoover", "Dark Skies. Praesent molestie orci augue, vitae euismod velit Dark Skies. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra Dark Skies. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { 3, "Julian Button", "Vanish in the Sunset. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Vanish in the Sunset ut ultricies.\r\n\r\nNunc malesuada viverra Vanish in the Sunset. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { 4, "Abby Muscles", "Cotton Candy. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Cotton Candy facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra Cotton Candy. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { 5, "Ron Parker", "Rock in the Ocean, vitae euismod velit sollicitudin ac. Rock in the Ocean facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra Rock in the Ocean. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { 6, "Laura Phantom", "Leaves and Wonders sodales libero. Praesent molestie orci augue, Leaves and Wonders velit sollicitudin ac. Leaves and Wonders facilisis nibh ut ultricies.\r\n\r\nNunc Leaves and Wonders. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
