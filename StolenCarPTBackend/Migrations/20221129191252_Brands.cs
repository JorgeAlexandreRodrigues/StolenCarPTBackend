using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StolenCarPTBackend.Migrations
{
    public partial class Brands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Abarth" },
                    { 2L, "Acura" },
                    { 3L, "Alfa Romeo" },
                    { 4L, "Aston Martin" },
                    { 5L, "Audi" },
                    { 6L, "Bentley" },
                    { 7L, "BMW" },
                    { 8L, "Bugatti" },
                    { 9L, "Cadillac" },
                    { 10L, "Chevrolet" },
                    { 11L, "Chrysler" },
                    { 12L, "Citroen" },
                    { 13L, "Cupra" },
                    { 14L, "Dacia" },
                    { 15L, "Daewoo" },
                    { 16L, "Daihatsu" },
                    { 17L, "Datsun" },
                    { 18L, "Dodge" },
                    { 19L, "DS" },
                    { 20L, "Ferrari" },
                    { 21L, "Fiat" },
                    { 22L, "Ford" },
                    { 23L, "Honda" },
                    { 24L, "Hummer" },
                    { 25L, "Hyundai" },
                    { 26L, "Infiniti" },
                    { 27L, "Isuzu" },
                    { 28L, "Iveco" },
                    { 29L, "Jaguar" },
                    { 30L, "Jeep" },
                    { 31L, "Kia" },
                    { 32L, "Lamborghini" },
                    { 33L, "Lancia" },
                    { 34L, "Land Rover" },
                    { 35L, "Lexus" },
                    { 36L, "Lincoln" },
                    { 37L, "Lotus" },
                    { 38L, "Maserati" },
                    { 39L, "Maybach" },
                    { 40L, "Mazda" },
                    { 41L, "McLaren" },
                    { 42L, "Mercedes" },
                    { 43L, "MG" },
                    { 44L, "Mini" },
                    { 45L, "Mitsubishi" },
                    { 46L, "Nissan" },
                    { 47L, "Opel" },
                    { 48L, "Peugeot" },
                    { 49L, "Pontiac" },
                    { 50L, "Porsche" },
                    { 51L, "Renault" },
                    { 52L, "Rolls-Royce" },
                    { 53L, "Rover" },
                    { 54L, "Saab" },
                    { 55L, "Seat" },
                    { 56L, "Skoda" },
                    { 57L, "Smart" },
                    { 58L, "Ssang Yong" },
                    { 59L, "Subaru" },
                    { 60L, "Suzuki" },
                    { 61L, "Tesla" },
                    { 62L, "Toyota" },
                    { 63L, "Volkswagen" },
                    { 64L, "Volvo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
