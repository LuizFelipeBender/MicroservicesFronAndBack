using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Product_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product_Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Product_Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product_Category_Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Product_Description", "Image_url", "Product_Name", "Product_Price", "Product_Category_Name" },
                values: new object[] { 1u, "Apple fruit", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg", "Apple", 12.29m, "Fruit" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Product_Description", "Image_url", "Product_Name", "Product_Price", "Product_Category_Name" },
                values: new object[] { 2u, "Grape fruit", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg", "Grape", 3.29m, "Fruit" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Product_Description", "Image_url", "Product_Name", "Product_Price", "Product_Category_Name" },
                values: new object[] { 3u, "Grape fruit", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg", "Grape", 3.29m, "Fruit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
