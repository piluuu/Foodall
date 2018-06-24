using Foodall.Domain;
using Microsoft.EntityFrameworkCore;

namespace Foodall.Data
{
    public class FoodallContext : DbContext
    {
        public DbSet<Member> Members { get; set;}
        public DbSet<Business> Businesses { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = FoodallData; Trusted_Connection = True; ");
        }
    }
}
