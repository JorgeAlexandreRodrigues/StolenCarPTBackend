using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StolenCarPTBackend.Migrations
{
    public partial class DevDBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Aveiro" },
                    { 2L, "Beja" },
                    { 3L, "Braga" },
                    { 4L, "Bragança" },
                    { 5L, "Castelo Branco" },
                    { 6L, "Coimbra" },
                    { 7L, "Evora" },
                    { 8L, "Faro" },
                    { 9L, "Guarda" },
                    { 10L, "Leirua" },
                    { 11L, "Lisboa" },
                    { 12L, "Portalegre" },
                    { 13L, "Porto" },
                    { 14L, "Santarem" },
                    { 15L, "Setubal" },
                    { 16L, "Viana do Castelo" },
                    { 17L, "Vila Real" },
                    { 18L, "Viseu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
