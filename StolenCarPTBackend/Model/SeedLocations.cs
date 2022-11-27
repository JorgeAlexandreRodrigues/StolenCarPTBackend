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
                    Name = "Vila Nova de Famalicao",
                    district_id= 3,
                },
                new Locations
                {
                    Id = 2,
                    Name = "Barcelos",
                    district_id= 3,
                },
                new Locations
                {
                    Id = 3,
                    Name = "Trofa",
                    district_id = 13,
                });
        }
    }

}

