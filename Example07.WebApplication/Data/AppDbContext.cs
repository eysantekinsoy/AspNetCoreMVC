using Example07.WebApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example07.WebApplication.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Example07.WebApplication.Data.Entities.Hotel> Hotel { get; set; } = default!;
    }
}
