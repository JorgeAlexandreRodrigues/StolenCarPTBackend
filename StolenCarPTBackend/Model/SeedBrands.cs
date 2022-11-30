using Microsoft.EntityFrameworkCore;

namespace StolenCarPTBackend.Model
{
    public static class SeedBrands
    {
        public static void Seedbrands(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>().HasData(
              new Brands
              {
                  Id = 1,
                  Name = "Abarth"
              }, 
              new Brands
              {
                  Id = 2,
                  Name = "Acura"
              },
              new Brands
              {
                  Id = 3,
                  Name = "Alfa Romeo"
              }, 
              new Brands
              {
                  Id = 4,
                  Name = "Aston Martin"
              }, 
              new Brands
              {
                  Id = 5,
                  Name = "Audi"
              }, 
              new Brands
              {
                  Id = 6,
                  Name = "Bentley"
              }, 
              new Brands
              {
                  Id = 7,
                  Name = "BMW"
              }, 
              new Brands
              {
                  Id = 8,
                  Name = "Bugatti"
              }, 
              new Brands
              {
                  Id = 9,
                  Name = "Cadillac"
              }, 
              new Brands
              {
                  Id = 10,
                  Name = "Chevrolet"
              }, 
              new Brands
              {
                  Id = 11,
                  Name = "Chrysler"
              }, 
              new Brands
              {
                  Id = 12,
                  Name = "Citroen"
              }, 
              new Brands
              {
                  Id = 13,
                  Name = "Cupra"
              }, 
              new Brands
              {
                  Id = 14,
                  Name = "Dacia"
              }, 
              new Brands
              {
                  Id = 15,
                  Name = "Daewoo"
              }, 
              new Brands
              {
                  Id = 16,
                  Name = "Daihatsu"
              }, 
              new Brands
              {
                  Id = 17,
                  Name = "Datsun"
              }, new Brands
              {
                  Id = 18,
                  Name = "Dodge"
              }, 
              new Brands
              {
                  Id = 19,
                  Name = "DS"
              }, 
              new Brands
              {
                  Id = 20,
                  Name = "Ferrari"
              }, 
              new Brands
              {
                  Id = 21,
                  Name = "Fiat"
              }, 
              new Brands
              {
                  Id = 22,
                  Name = "Ford"
              },
              new Brands
              {
                  Id = 23,
                  Name = "Honda"
              },
              new Brands
              {
                  Id = 24,
                  Name = "Hummer"
              },
              new Brands
              {
                  Id = 25,
                  Name = "Hyundai"
              },
              new Brands
              {
                  Id = 26,
                  Name = "Infiniti"
              }, 
              new Brands
              {
                  Id = 27,
                  Name = "Isuzu"
              }, 
              new Brands
              {
                  Id = 28,
                  Name = "Iveco"
              }, 
              new Brands
              {
                  Id = 29,
                  Name = "Jaguar"
              }, 
              new Brands
              {
                  Id = 30,
                  Name = "Jeep"
              }, 
              new Brands
              {
                  Id = 31,
                  Name = "Kia"
              }, 
              new Brands
              {
                  Id = 32,
                  Name = "Lamborghini"
              }, 
              new Brands
              {
                  Id = 33,
                  Name = "Lancia"
              }, 
              new Brands
              {
                  Id = 34,
                  Name = "Land Rover"
              }, 
              new Brands
              {
                  Id = 35,
                  Name = "Lexus"
              }, 
              new Brands
              {
                  Id = 36,
                  Name = "Lincoln"
              }, 
              new Brands
              {
                  Id = 37,
                  Name = "Lotus"
              }, 
              new Brands
              {
                  Id = 38,
                  Name = "Maserati"
              }, 
              new Brands
              {
                  Id = 39,
                  Name = "Maybach"
              }, 
              new Brands
              {
                  Id = 40,
                  Name = "Mazda"
              }, 
              new Brands
              {
                  Id = 41,
                  Name = "McLaren"
              }, 
              new Brands
              {
                  Id = 42,
                  Name = "Mercedes"
              }, 
              new Brands
              {
                  Id = 43,
                  Name = "MG"
              }, 
              new Brands
              {
                  Id = 44,
                  Name = "Mini"
              }, 
              new Brands
              {
                  Id = 45,
                  Name = "Mitsubishi"
              }, 
              new Brands
              {
                  Id = 46,
                  Name = "Nissan"
              }, 
              new Brands
              {
                  Id = 47,
                  Name = "Opel"
              },
              new Brands
              {
                  Id = 48,
                  Name = "Peugeot"
              },
              new Brands
              {
                  Id = 49,
                  Name = "Pontiac"
              }, 
              new Brands
              {
                  Id = 50,
                  Name = "Porsche"
              }, 
              new Brands
              {
                  Id = 51,
                  Name = "Renault"
              }, 
              new Brands
              {
                  Id = 52,
                  Name = "Rolls-Royce"
              }, 
              new Brands
              {
                  Id = 53,
                  Name = "Rover"
              }, 
              new Brands
              {
                  Id = 54,
                  Name = "Saab"
              },
              new Brands
              {
                  Id = 55,
                  Name = "Seat"
              }, 
              new Brands
              {
                  Id = 56,
                  Name = "Skoda"
              }, 
              new Brands
              {
                  Id = 57,
                  Name = "Smart"
              },
              new Brands
              {
                  Id = 58,
                  Name = "Ssang Yong"
              }, 
              new Brands
              {
                  Id = 59,
                  Name = "Subaru"
              }, 
              new Brands
              {
                  Id = 60,
                  Name = "Suzuki"
              }, 
              new Brands
              {
                  Id = 61,
                  Name = "Tesla"
              }, 
              new Brands
              {
                  Id = 62,
                  Name = "Toyota"
              },
              new Brands
              {
                  Id = 63,
                  Name = "Volkswagen"
              }, 
              new Brands
              {
                  Id = 64,
                  Name = "Volvo"
              });
        }
    }
}
