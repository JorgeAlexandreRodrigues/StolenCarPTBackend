using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StolenCarPTBackend.Migrations
{
    public partial class DevDB : Migration
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

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    district_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Districts_district_id",
                        column: x => x.district_id,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 10L, "Leiria" },
                    { 11L, "Lisboa" },
                    { 12L, "Portalegre" },
                    { 13L, "Porto" },
                    { 14L, "Santarem" },
                    { 15L, "Setubal" },
                    { 16L, "Viana do Castelo" },
                    { 17L, "Vila Real" },
                    { 18L, "Viseu" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "district_id" },
                values: new object[,]
                {
                    { 1L, "Águeda", 1L },
                    { 2L, "Albergaria-a-Velha", 1L },
                    { 3L, "Anadia", 1L },
                    { 4L, "Arouca", 1L },
                    { 5L, "Aveiro", 1L },
                    { 6L, "Castelo de Paiva", 1L },
                    { 7L, "Espinho", 1L },
                    { 8L, "Estarreja", 1L },
                    { 9L, "Ílhavo", 1L },
                    { 10L, "Mealhada", 1L },
                    { 11L, "Murtosa", 1L },
                    { 12L, "Oliveira de Azeméis", 1L },
                    { 13L, "Oliveira do Bairro", 1L },
                    { 14L, "Ovar", 1L },
                    { 15L, "Santa Maria da Feira", 1L },
                    { 16L, "São João da Madeira", 1L },
                    { 17L, "Sever do Vouga", 1L },
                    { 18L, "Vagos", 1L },
                    { 19L, "Vale de Cambra", 1L },
                    { 20L, "Aljustrel", 2L },
                    { 21L, "Almodôvar", 2L },
                    { 22L, "Alvito", 2L },
                    { 23L, "Barrancos", 2L },
                    { 24L, "Beja", 2L },
                    { 25L, "Castro Verde", 2L },
                    { 26L, "Cuba", 2L },
                    { 27L, "Ferreira do Alentejo", 2L },
                    { 28L, "Mértola", 2L },
                    { 29L, "Moura", 2L },
                    { 30L, "Odemira", 2L },
                    { 31L, "Ourique", 2L },
                    { 32L, "Serpa", 2L },
                    { 33L, "Vidigueira", 2L },
                    { 34L, "Amares", 3L },
                    { 35L, "Barcelos", 3L },
                    { 36L, "Braga", 3L },
                    { 37L, "Cabeceiras de Basto", 3L },
                    { 38L, "Celorico de Basto", 3L },
                    { 39L, "Esposende", 3L },
                    { 40L, "Fafe", 3L },
                    { 41L, "Guimarães", 3L },
                    { 42L, "Póvoa de Lanhoso", 3L },
                    { 43L, "Terras de Bouro", 3L },
                    { 44L, "Vieira do Minho", 3L },
                    { 45L, "Vila Nova de Famalicão", 3L },
                    { 46L, "Vila Verde", 3L },
                    { 47L, "Vizela", 3L },
                    { 48L, "Alfândega da Fé", 4L },
                    { 49L, "Bragança", 4L },
                    { 50L, "Carrazeda de Ansiães", 4L },
                    { 51L, "Freixo de Espada à Cinta", 4L },
                    { 52L, "Macedo de Cavaleiros", 4L },
                    { 53L, "Miranda do Douro", 4L },
                    { 54L, "Mirandela", 4L },
                    { 55L, "Mogadouro", 4L },
                    { 56L, "Torre de Moncorvo", 4L },
                    { 57L, "Vila Flor", 4L },
                    { 58L, "Vimioso", 4L },
                    { 59L, "Vinhais", 4L },
                    { 60L, "Belmonte", 5L },
                    { 61L, "Castelo Branco", 5L },
                    { 62L, "Covilhã", 5L },
                    { 63L, "Fundão", 5L },
                    { 64L, "Idanha-a-Nova", 5L },
                    { 65L, "Oleiros", 5L },
                    { 66L, "Penamacor", 5L },
                    { 67L, "Proença-a-Nova", 5L },
                    { 68L, "Sertã", 5L },
                    { 69L, "Vila de Rei", 5L },
                    { 70L, "Vila Velha de Ródão", 5L },
                    { 71L, "Arganil", 6L },
                    { 72L, "Cantanhede", 6L },
                    { 73L, "Coimbra", 6L },
                    { 74L, "Condeixa-a-Nova", 6L },
                    { 75L, "Figueira da Foz", 6L },
                    { 76L, "Góis", 6L },
                    { 77L, "Lousã", 6L },
                    { 78L, "Mira", 6L },
                    { 79L, "Miranda do Corvo", 6L },
                    { 80L, "Montemor-o-Velho", 6L },
                    { 81L, "Oliveira do Hospital", 6L },
                    { 82L, "Pampilhosa da Serra", 6L },
                    { 83L, "Penacova", 6L },
                    { 84L, "Penela", 6L },
                    { 85L, "Soure", 6L },
                    { 86L, "Tábua", 6L },
                    { 87L, "Vila Nova de Poiares", 6L },
                    { 88L, "Alandroal", 7L },
                    { 89L, "Arraiolos", 7L },
                    { 90L, "Borba", 7L },
                    { 91L, "Estremoz", 7L },
                    { 92L, "Évora", 7L },
                    { 93L, "Montemor-o-Novo", 7L },
                    { 94L, "Mora", 7L },
                    { 95L, "Mourão", 7L },
                    { 96L, "Portel", 7L },
                    { 97L, "Redondo", 7L },
                    { 98L, "Reguengos de Monsaraz", 7L },
                    { 99L, "Vendas Novas", 7L },
                    { 100L, "Viana do Alentejo", 7L },
                    { 101L, "Vila Viçosa", 7L },
                    { 102L, "Albufeira", 8L },
                    { 103L, "Alcoutim", 8L },
                    { 104L, "Aljezur", 8L },
                    { 105L, "Castro Marim", 8L },
                    { 106L, "Faro", 8L },
                    { 107L, "Lagoa", 8L },
                    { 108L, "Lagos", 8L },
                    { 109L, "Loulé", 8L },
                    { 110L, "Monchique", 8L },
                    { 111L, "Olhão", 8L },
                    { 112L, "Portimão", 8L },
                    { 113L, "São Brás de Alportel", 8L },
                    { 114L, "Silves", 8L },
                    { 115L, "Tavira", 8L },
                    { 116L, "Vila do Bispo", 8L },
                    { 117L, "Vila Real de Santo António", 8L },
                    { 118L, "Aguiar da Beira", 9L },
                    { 119L, "Almeida", 9L },
                    { 120L, "Celorico da Beira", 9L },
                    { 121L, "Figueira de Castelo Rodrigo", 9L },
                    { 122L, "Fornos de Algodres", 9L },
                    { 123L, "Gouveia", 9L },
                    { 124L, "Guarda", 9L },
                    { 125L, "Manteigas", 9L },
                    { 126L, "Mêda", 9L },
                    { 127L, "Pinhel", 9L },
                    { 128L, "Sabugal", 9L },
                    { 129L, "Seia", 9L },
                    { 130L, "Trancoso", 9L },
                    { 131L, "Vila Nova de Foz Côa", 9L },
                    { 132L, "Alcobaça", 10L },
                    { 133L, "Alvaiázere", 10L },
                    { 134L, "Ansião", 10L },
                    { 135L, "Batalha", 10L },
                    { 136L, "Bombarral", 10L },
                    { 137L, "Caldas da Rainha", 10L },
                    { 138L, "Castanheira de Pêra", 10L },
                    { 139L, "Figueiró dos Vinhos", 10L },
                    { 140L, "Leiria", 10L },
                    { 141L, "Marinha Grande", 10L },
                    { 142L, "Nazaré", 10L },
                    { 143L, "Óbidos", 10L },
                    { 144L, "Pedrógão Grande", 10L },
                    { 145L, "Peniche", 10L },
                    { 146L, "Pombal", 10L },
                    { 147L, "Porto de Mós", 10L },
                    { 148L, "Alenquer", 11L },
                    { 149L, "Amadora", 11L },
                    { 150L, "Arruda dos Vinhos", 11L },
                    { 151L, "Azambuja", 11L },
                    { 152L, "Cadaval", 11L },
                    { 153L, "Cascais", 11L },
                    { 154L, "Lisboa", 11L },
                    { 155L, "Loures", 11L },
                    { 156L, "Lourinhã", 11L },
                    { 157L, "Mafra", 11L },
                    { 158L, "Odivelas", 11L },
                    { 159L, "Oeiras", 11L },
                    { 160L, "Sintra", 11L },
                    { 161L, "Sobral de Monte Agraço", 11L },
                    { 162L, "Torres Vedras", 11L },
                    { 163L, "Vila Franca de Xira", 11L },
                    { 164L, "Alter do Chão", 12L },
                    { 165L, "Arronches", 12L },
                    { 166L, "Avis", 12L },
                    { 167L, "Campo Maior", 12L },
                    { 168L, "Castelo de Vide", 12L },
                    { 169L, "Crato", 12L },
                    { 170L, "Elvas", 12L },
                    { 171L, "Fronteira", 12L },
                    { 172L, "Gavião", 12L },
                    { 173L, "Marvão", 12L },
                    { 174L, "Monforte", 12L },
                    { 175L, "Nisa", 12L },
                    { 176L, "Ponte de Sor", 12L },
                    { 177L, "Portalegre", 12L },
                    { 178L, "Sousel", 12L },
                    { 179L, "Amarante", 13L },
                    { 180L, "Baião", 13L },
                    { 181L, "Felgueiras", 13L },
                    { 182L, "Gondomar", 13L },
                    { 183L, "Lousada", 13L },
                    { 184L, "Maia", 13L },
                    { 185L, "Marco de Canaveses", 13L },
                    { 186L, "Matosinhos", 13L },
                    { 187L, "Paços de Ferreira", 13L },
                    { 188L, "Paredes", 13L },
                    { 189L, "Penafiel", 13L },
                    { 190L, "Porto", 13L },
                    { 191L, "Póvoa de Varzim", 13L },
                    { 192L, "Santo Tirso", 13L },
                    { 193L, "Trofa", 13L },
                    { 194L, "Valongo", 13L },
                    { 195L, "Vila do Conde", 13L },
                    { 196L, "Vila Nova de Gaia", 13L },
                    { 197L, "Abrantes", 14L },
                    { 198L, "Alcanena", 14L },
                    { 199L, "Almeirim", 14L },
                    { 200L, "Alpiarça", 14L },
                    { 201L, "Benavente", 14L },
                    { 202L, "Cartaxo", 14L },
                    { 203L, "Chamusca", 14L },
                    { 204L, "Constância", 14L },
                    { 205L, "Coruche", 14L },
                    { 206L, "Entroncamento", 14L },
                    { 207L, "Ferreira do Zêzere", 14L },
                    { 208L, "Golegã", 14L },
                    { 209L, "Mação", 14L },
                    { 210L, "Ourém", 14L },
                    { 211L, "Rio Maior", 14L },
                    { 212L, "Salvaterra de Magos", 14L },
                    { 213L, "Santarém", 14L },
                    { 214L, "Sardoal", 14L },
                    { 215L, "Tomar", 14L },
                    { 216L, "Torres Novas", 14L },
                    { 217L, "Vila Nova da Barquinha", 14L },
                    { 218L, "Alcácer do Sal", 15L },
                    { 219L, "Alcochete", 15L },
                    { 220L, "Almada", 15L },
                    { 221L, "Barreiro", 15L },
                    { 222L, "Grândola", 15L },
                    { 223L, "Moita", 15L },
                    { 224L, "Montijo", 15L },
                    { 225L, "Palmela", 15L },
                    { 226L, "Santiago do Cacém", 15L },
                    { 227L, "Seixal", 15L },
                    { 228L, "Sesimbra", 15L },
                    { 229L, "Setúbal", 15L },
                    { 230L, "Sines", 15L },
                    { 231L, "Arcos de Valdevez", 16L },
                    { 232L, "Caminha", 16L },
                    { 233L, "Melgaço", 16L },
                    { 234L, "Monção", 16L },
                    { 235L, "Paredes de Coura", 16L },
                    { 236L, "Ponte da Barca", 16L },
                    { 237L, "Ponte de Lima", 16L },
                    { 238L, "Valença", 16L },
                    { 239L, "Viana do Castelo", 16L },
                    { 240L, "Vila Nova de Cerveira", 16L },
                    { 241L, "Alijó", 17L },
                    { 242L, "Boticas", 17L },
                    { 243L, "Chaves", 17L },
                    { 244L, "Mesão Frio", 17L },
                    { 245L, "Mondim de Basto", 17L },
                    { 246L, "Montalegre", 17L },
                    { 247L, "Murça", 17L },
                    { 248L, "Peso da Régua", 17L },
                    { 249L, "Ribeira de Pena", 17L },
                    { 250L, "Sabrosa", 17L },
                    { 251L, "Santa Marta de Penaguião", 17L },
                    { 252L, "Valpaços", 17L },
                    { 253L, "Vila Pouca de Aguiar", 17L },
                    { 254L, "Vila Real", 17L },
                    { 255L, "Armamar", 18L },
                    { 256L, "Carregal do Sal", 18L },
                    { 257L, "Castro Daire", 18L },
                    { 258L, "Cinfães", 18L },
                    { 259L, "Lamego", 18L },
                    { 260L, "Mangualde", 18L },
                    { 261L, "Moimenta da Beira", 18L },
                    { 262L, "Mortágua", 18L },
                    { 263L, "Nelas", 18L },
                    { 264L, "Oliveira de Frades", 18L },
                    { 265L, "Penalva do Castelo", 18L },
                    { 266L, "Penedono", 18L },
                    { 267L, "Resende", 18L },
                    { 268L, "Santa Comba Dão", 18L },
                    { 269L, "São João da Pesqueira", 18L },
                    { 270L, "São Pedro do Sul", 18L },
                    { 271L, "Sátão", 18L },
                    { 272L, "Sernancelhe", 18L },
                    { 273L, "Tabuaço", 18L },
                    { 274L, "Tarouca", 18L },
                    { 275L, "Tondela", 18L },
                    { 276L, "Vila Nova de Paiva", 18L },
                    { 277L, "Viseu", 18L },
                    { 278L, "Vouzela", 18L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_district_id",
                table: "Locations",
                column: "district_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
