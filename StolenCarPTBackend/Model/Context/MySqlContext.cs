using Microsoft.EntityFrameworkCore;

namespace StolenCarPTBackend.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Models> Models { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seeddistricts();
            modelBuilder.Seedlocations();
            modelBuilder.Seedbrands();
            modelBuilder.Seedmodel();
        }
    }
}
