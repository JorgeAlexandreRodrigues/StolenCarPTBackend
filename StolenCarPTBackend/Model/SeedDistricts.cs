using Microsoft.EntityFrameworkCore;

namespace StolenCarPTBackend.Model
{
    public static class SeedDistricts
    {
        public static void Seeddistricts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Districts>().HasData(
                new Districts
                {
                    Id = 1,
                    Name = "Aveiro",
                },
                new Districts
                {
                    Id = 2,
                    Name="Beja"
                },
                new Districts
                {
                    Id = 3,
                    Name = "Braga"
                },
                new Districts
                {
                     Id = 4,
                     Name = "Bragança"
                },
                new Districts
                {
                      Id = 5,
                      Name = "Castelo Branco"
                },
                new Districts
                {
                     Id = 6,
                     Name = "Coimbra"
                },
                new Districts
                {
                     Id = 7,
                     Name = "Evora"
                },
                new Districts
                {
                     Id = 8,
                     Name = "Faro"
                },
                new Districts
                {
                     Id = 9,
                     Name = "Guarda"
                },
                new Districts
                {
                     Id = 10,
                     Name = "Leiria"
                },
                new Districts
                {
                     Id = 11,
                     Name = "Lisboa"
                },
                new Districts
                {
                     Id = 12,
                     Name = "Portalegre"
                },
                new Districts
                {
                     Id = 13,
                     Name = "Porto"
                },
                new Districts
                {
                     Id = 14,
                     Name = "Santarem"
                },
                new Districts
                {
                     Id = 15,
                     Name = "Setubal"
                },
                new Districts
                {
                     Id = 16,
                     Name = "Viana do Castelo"
                },
                new Districts
                {
                     Id = 17,
                     Name = "Vila Real"
                },
                new Districts
                {
                    Id = 18,
                    Name = "Viseu"
                }
                );
        }
    }
}
