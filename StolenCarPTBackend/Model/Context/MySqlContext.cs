using Microsoft.EntityFrameworkCore;

namespace StolenCarPTBackend.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        public DbSet<Districts> Districts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seeddistricts();
        }
    }
}
