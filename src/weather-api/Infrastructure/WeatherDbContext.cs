using Microsoft.EntityFrameworkCore;
using weather_api.Model;

namespace weather_api.Infrastructure
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Temperature> Temperatures { get; set; }
    }
}
