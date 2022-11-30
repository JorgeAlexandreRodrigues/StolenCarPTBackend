using Microsoft.EntityFrameworkCore;

namespace StolenCarPTBackend.Model
{
    public static class SeedLocations
    {
        public static void Seedlocations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locations>().HasData(
              new Locations
              {
                  Id = 1,
                  Name = "Águeda",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 2,
                  Name = "Albergaria-a-Velha",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 3,
                  Name = "Anadia",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 4,
                  Name = "Arouca",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 5,
                  Name = "Aveiro",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 6,
                  Name = "Castelo de Paiva",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 7,
                  Name = "Espinho",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 8,
                  Name = "Estarreja",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 9,
                  Name = "Ílhavo",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 10,
                  Name = "Mealhada",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 11,
                  Name = "Murtosa",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 12,
                  Name = "Oliveira de Azeméis",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 13,
                  Name = "Oliveira do Bairro",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 14,
                  Name = "Ovar",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 15,
                  Name = "Santa Maria da Feira",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 16,
                  Name = "São João da Madeira",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 17,
                  Name = "Sever do Vouga",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 18,
                  Name = "Vagos",
                  district_id = 1,
              }, 
              new Locations
              {
                  Id = 19,
                  Name = "Vale de Cambra",
                  district_id = 1,
              },
              new Locations
              {
                  Id = 20,
                  Name = "Aljustrel",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 21,
                  Name = "Almodôvar",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 22,
                  Name = "Alvito",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 23,
                  Name = "Barrancos",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 24,
                  Name = "Beja",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 25,
                  Name = "Castro Verde",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 26,
                  Name = "Cuba",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 27,
                  Name = "Ferreira do Alentejo",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 28,
                  Name = "Mértola",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 29,
                  Name = "Moura",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 30,
                  Name = "Odemira",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 31,
                  Name = "Ourique",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 32,
                  Name = "Serpa",
                  district_id = 2,
              }, 
              new Locations
              {
                  Id = 33,
                  Name = "Vidigueira",
                  district_id = 2,
              },
              new Locations
              {
                  Id = 34,
                  Name = "Amares",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 35,
                  Name = "Barcelos",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 36,
                  Name = "Braga",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 37,
                  Name = "Cabeceiras de Basto",
                  district_id = 3,
              }, new
              Locations
              {
                  Id = 38,
                  Name = "Celorico de Basto",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 39,
                  Name = "Esposende",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 40,
                  Name = "Fafe",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 41,
                  Name = "Guimarães",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 42,
                  Name = "Póvoa de Lanhoso",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 43,
                  Name = "Terras de Bouro",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 44,
                  Name = "Vieira do Minho",
                  district_id = 3,
              },
              new Locations
              {
                  Id = 45,
                  Name = "Vila Nova de Famalicão",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 46,
                  Name = "Vila Verde",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 47,
                  Name = "Vizela",
                  district_id = 3,
              }, 
              new Locations
              {
                  Id = 48,
                  Name = "Alfândega da Fé",
                  district_id = 4,
              },
              new Locations
              {
                  Id = 49,
                  Name = "Bragança",
                  district_id = 4,
              },
              new Locations
              {
                  Id = 50,
                  Name = "Carrazeda de Ansiães",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 51,
                  Name = "Freixo de Espada à Cinta",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 52,
                  Name = "Macedo de Cavaleiros",
                  district_id = 4,
              },
              new Locations
              {
                  Id = 53,
                  Name = "Miranda do Douro",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 54,
                  Name = "Mirandela",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 55,
                  Name = "Mogadouro",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 56,
                  Name = "Torre de Moncorvo",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 57,
                  Name = "Vila Flor",
                  district_id = 4,
              }, 
              new Locations
              {
                  Id = 58,
                  Name = "Vimioso",
                  district_id = 4,
              },
              new Locations
              {
                  Id = 59,
                  Name = "Vinhais",
                  district_id = 4,
              },
              new Locations
              {
                  Id = 60,
                  Name = "Belmonte",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 61,
                  Name = "Castelo Branco",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 62,
                  Name = "Covilhã",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 63,
                  Name = "Fundão",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 64,
                  Name = "Idanha-a-Nova",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 65,
                  Name = "Oleiros",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 66,
                  Name = "Penamacor",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 67,
                  Name = "Proença-a-Nova",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 68,
                  Name = "Sertã",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 69,
                  Name = "Vila de Rei",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 70,
                  Name = "Vila Velha de Ródão",
                  district_id = 5,
              }, 
              new Locations
              {
                  Id = 71,
                  Name = "Arganil",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 72,
                  Name = "Cantanhede",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 73,
                  Name = "Coimbra",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 74,
                  Name = "Condeixa-a-Nova",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 75,
                  Name = "Figueira da Foz",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 76,
                  Name = "Góis",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 77,
                  Name = "Lousã",
                  district_id = 6,
              },
              new Locations
              {
                  Id = 78,
                  Name = "Mira",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 79,
                  Name = "Miranda do Corvo",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 80,
                  Name = "Montemor-o-Velho",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 81,
                  Name = "Oliveira do Hospital",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 82,
                  Name = "Pampilhosa da Serra",
                  district_id = 6,
              },
              new Locations
              {
                  Id = 83,
                  Name = "Penacova",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 84,
                  Name = "Penela",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 85,
                  Name = "Soure",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 86,
                  Name = "Tábua",
                  district_id = 6,
              },
              new Locations
              {
                  Id = 87,
                  Name = "Vila Nova de Poiares",
                  district_id = 6,
              }, 
              new Locations
              {
                  Id = 88,
                  Name = "Alandroal",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 89,
                  Name = "Arraiolos",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 90,
                  Name = "Borba",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 91,
                  Name = "Estremoz",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 92,
                  Name = "Évora",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 93,
                  Name = "Montemor-o-Novo",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 94,
                  Name = "Mora",
                  district_id = 7,
              },
              new Locations
              {
                  Id = 95,
                  Name = "Mourão",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 96,
                  Name = "Portel",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 97,
                  Name = "Redondo",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 98,
                  Name = "Reguengos de Monsaraz",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 99,
                  Name = "Vendas Novas",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 100,
                  Name = "Viana do Alentejo",
                  district_id = 7,
              },
              new Locations
              {
                  Id = 101,
                  Name = "Vila Viçosa",
                  district_id = 7,
              }, 
              new Locations
              {
                  Id = 102,
                  Name = "Albufeira",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 103,
                  Name = "Alcoutim",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 104,
                  Name = "Aljezur",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 105,
                  Name = "Castro Marim",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 106,
                  Name = "Faro",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 107,
                  Name = "Lagoa",
                  district_id = 8,
              },
              new Locations
              {
                  Id = 108,
                  Name = "Lagos",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 109,
                  Name = "Loulé",
                  district_id = 8,
              },
              new Locations
              {
                  Id = 110,
                  Name = "Monchique",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 111,
                  Name = "Olhão",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 112,
                  Name = "Portimão",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 113,
                  Name = "São Brás de Alportel",
                  district_id = 8,
              },
              new Locations
              {
                  Id = 114,
                  Name = "Silves",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 115,
                  Name = "Tavira",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 116,
                  Name = "Vila do Bispo",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 117,
                  Name = "Vila Real de Santo António",
                  district_id = 8,
              }, 
              new Locations
              {
                  Id = 118,
                  Name = "Aguiar da Beira",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 119,
                  Name = "Almeida",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 120,
                  Name = "Celorico da Beira",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 121,
                  Name = "Figueira de Castelo Rodrigo",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 122,
                  Name = "Fornos de Algodres",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 123,
                  Name = "Gouveia",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 124,
                  Name = "Guarda",
                  district_id = 9,
              },
              new Locations
              {
                  Id = 125,
                  Name = "Manteigas",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 126,
                  Name = "Mêda",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 127,
                  Name = "Pinhel",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 128,
                  Name = "Sabugal",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 129,
                  Name = "Seia",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 130,
                  Name = "Trancoso",
                  district_id = 9,
              }, 
              new Locations
              {
                  Id = 131,
                  Name = "Vila Nova de Foz Côa",
                  district_id = 9,
              },
              new Locations
              {
                  Id = 132,
                  Name = "Alcobaça",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 133,
                  Name = "Alvaiázere",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 134,
                  Name = "Ansião",
                  district_id = 10,
              },
              new Locations
              {
                  Id = 135,
                  Name = "Batalha",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 136,
                  Name = "Bombarral",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 137,
                  Name = "Caldas da Rainha",
                  district_id = 10,
              },
              new Locations
              {
                  Id = 138,
                  Name = "Castanheira de Pêra",
                  district_id = 10,
              },
              new Locations
              {
                  Id = 139,
                  Name = "Figueiró dos Vinhos",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 140,
                  Name = "Leiria",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 141,
                  Name = "Marinha Grande",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 142,
                  Name = "Nazaré",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 143,
                  Name = "Óbidos",
                  district_id = 10,
              },
              new Locations
              {
                  Id = 144,
                  Name = "Pedrógão Grande",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 145,
                  Name = "Peniche",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 146,
                  Name = "Pombal",
                  district_id = 10,
              }, 
              new Locations
              {
                  Id = 147,
                  Name = "Porto de Mós",
                  district_id = 10,
              },
              new Locations
              {
                  Id = 148,
                  Name = "Alenquer",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 149,
                  Name = "Amadora",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 150,
                  Name = "Arruda dos Vinhos",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 151,
                  Name = "Azambuja",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 152,
                  Name = "Cadaval",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 153,
                  Name = "Cascais",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 154,
                  Name = "Lisboa",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 155,
                  Name = "Loures",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 156,
                  Name = "Lourinhã",
                  district_id = 11,
              },
              new Locations
              {
                  Id = 157,
                  Name = "Mafra",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 158,
                  Name = "Odivelas",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 159,
                  Name = "Oeiras",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 160,
                  Name = "Sintra",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 161,
                  Name = "Sobral de Monte Agraço",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 162,
                  Name = "Torres Vedras",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 163,
                  Name = "Vila Franca de Xira",
                  district_id = 11,
              }, 
              new Locations
              {
                  Id = 164,
                  Name = "Alter do Chão",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 165,
                  Name = "Arronches",
                  district_id = 12,
              },
              new Locations
              {
                  Id = 166,
                  Name = "Avis",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 167,
                  Name = "Campo Maior",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 168,
                  Name = "Castelo de Vide",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 169,
                  Name = "Crato",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 170,
                  Name = "Elvas",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 171,
                  Name = "Fronteira",
                  district_id = 12,
              },
              new Locations
              {
                  Id = 172,
                  Name = "Gavião",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 173,
                  Name = "Marvão",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 174,
                  Name = "Monforte",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 175,
                  Name = "Nisa",
                  district_id = 12,
              }, 
              new Locations
              {
                  Id = 176,
                  Name = "Ponte de Sor",
                  district_id = 12,
              },
              new Locations
              {
                  Id = 177,
                  Name = "Portalegre",
                  district_id = 12,
              },
              new Locations
              {
                  Id = 178,
                  Name = "Sousel",
                  district_id = 12,
              },
              new Locations
              {
                  Id = 179,
                  Name = "Amarante",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 180,
                  Name = "Baião",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 181,
                  Name = "Felgueiras",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 182,
                  Name = "Gondomar",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 183,
                  Name = "Lousada",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 184,
                  Name = "Maia",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 185,
                  Name = "Marco de Canaveses",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 186,
                  Name = "Matosinhos",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 187,
                  Name = "Paços de Ferreira",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 188,
                  Name = "Paredes",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 189,
                  Name = "Penafiel",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 190,
                  Name = "Porto",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 191,
                  Name = "Póvoa de Varzim",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 192,
                  Name = "Santo Tirso",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 193,
                  Name = "Trofa",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 194,
                  Name = "Valongo",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 195,
                  Name = "Vila do Conde",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 196,
                  Name = "Vila Nova de Gaia",
                  district_id = 13,
              }, 
              new Locations
              {
                  Id = 197,
                  Name = "Abrantes",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 198,
                  Name = "Alcanena",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 199,
                  Name = "Almeirim",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 200,
                  Name = "Alpiarça",
                  district_id = 14,
              }, new Locations
              {
                  Id = 201,
                  Name = "Benavente",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 202,
                  Name = "Cartaxo",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 203,
                  Name = "Chamusca",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 204,
                  Name = "Constância",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 205,
                  Name = "Coruche",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 206,
                  Name = "Entroncamento",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 207,
                  Name = "Ferreira do Zêzere",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 208,
                  Name = "Golegã",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 209,
                  Name = "Mação",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 210,
                  Name = "Ourém",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 211,
                  Name = "Rio Maior",
                  district_id = 14,
              },
              new Locations
              {
                  Id = 212,
                  Name = "Salvaterra de Magos",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 213,
                  Name = "Santarém",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 214,
                  Name = "Sardoal",
                  district_id = 14,
              },
              new Locations
              {
                  Id = 215,
                  Name = "Tomar",
                  district_id = 14,
              },
              new Locations
              {
                  Id = 216,
                  Name = "Torres Novas",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 217,
                  Name = "Vila Nova da Barquinha",
                  district_id = 14,
              }, 
              new Locations
              {
                  Id = 218,
                  Name = "Alcácer do Sal",
                  district_id = 15,
              },
              new Locations
              {
                  Id = 219,
                  Name = "Alcochete",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 220,
                  Name = "Almada",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 221,
                  Name = "Barreiro",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 222,
                  Name = "Grândola",
                  district_id = 15,
              },
              new Locations
              {
                  Id = 223,
                  Name = "Moita",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 224,
                  Name = "Montijo",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 225,
                  Name = "Palmela",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 226,
                  Name = "Santiago do Cacém",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 227,
                  Name = "Seixal",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 228,
                  Name = "Sesimbra",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 229,
                  Name = "Setúbal",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 230,
                  Name = "Sines",
                  district_id = 15,
              }, 
              new Locations
              {
                  Id = 231,
                  Name = "Arcos de Valdevez",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 232,
                  Name = "Caminha",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 233,
                  Name = "Melgaço",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 234,
                  Name = "Monção",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 235,
                  Name = "Paredes de Coura",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 236,
                  Name = "Ponte da Barca",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 237,
                  Name = "Ponte de Lima",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 238,
                  Name = "Valença",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 239,
                  Name = "Viana do Castelo",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 240,
                  Name = "Vila Nova de Cerveira",
                  district_id = 16,
              }, 
              new Locations
              {
                  Id = 241,
                  Name = "Alijó",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 242,
                  Name = "Boticas",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 243,
                  Name = "Chaves",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 244,
                  Name = "Mesão Frio",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 245,
                  Name = "Mondim de Basto",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 246,
                  Name = "Montalegre",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 247,
                  Name = "Murça",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 248,
                  Name = "Peso da Régua",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 249,
                  Name = "Ribeira de Pena",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 250,
                  Name = "Sabrosa",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 251,
                  Name = "Santa Marta de Penaguião",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 252,
                  Name = "Valpaços",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 253,
                  Name = "Vila Pouca de Aguiar",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 254,
                  Name = "Vila Real",
                  district_id = 17,
              }, 
              new Locations
              {
                  Id = 255,
                  Name = "Armamar",
                  district_id = 18,
              },
              new Locations
              {
                  Id = 256,
                  Name = "Carregal do Sal",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 257,
                  Name = "Castro Daire",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 258,
                  Name = "Cinfães",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 259,
                  Name = "Lamego",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 260,
                  Name = "Mangualde",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 261,
                  Name = "Moimenta da Beira",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 262,
                  Name = "Mortágua",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 263,
                  Name = "Nelas",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 264,
                  Name = "Oliveira de Frades",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 265,
                  Name = "Penalva do Castelo",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 266,
                  Name = "Penedono",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 267,
                  Name = "Resende",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 268,
                  Name = "Santa Comba Dão",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 269,
                  Name = "São João da Pesqueira",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 270,
                  Name = "São Pedro do Sul",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 271,
                  Name = "Sátão",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 272,
                  Name = "Sernancelhe",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 273,
                  Name = "Tabuaço",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 274,
                  Name = "Tarouca",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 275,
                  Name = "Tondela",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 276,
                  Name = "Vila Nova de Paiva",
                  district_id = 18,
              }, 
              new Locations
              {
                  Id = 277,
                  Name = "Viseu",
                  district_id = 18,
              },
              new Locations
              {
                  Id = 278,
                  Name = "Vouzela",
                  district_id = 18,
              }
             );
        }
    }

}

