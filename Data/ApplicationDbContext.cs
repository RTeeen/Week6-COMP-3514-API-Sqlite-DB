using Microsoft.EntityFrameworkCore;

namespace Week6ind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities {get; set;}
        public DbSet<Province> Provinces {get; set;}

    }
}
