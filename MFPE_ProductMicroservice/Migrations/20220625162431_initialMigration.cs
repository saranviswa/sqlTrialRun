using Microsoft.EntityFrameworkCore.Migrations;

namespace MFPE_ProductMicroservice.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image_Name = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image_Name", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, "This is a brand new mobile phone", "MobilePhone.jpg", "Mobile phone", 15000.0, 2 },
                    { 2, "This is a brand new Pendrive", "PenDrive.jpg", "Pendrive", 2000.0, 3 },
                    { 3, "This is a brand new HeadPhone", "Headphone.jpg", "HeadPhones", 2000.0, 4 },
                    { 4, "This is a brand new Laptop", "Laptop.jpg", "Laptop", 35000.0, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
