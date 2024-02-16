using Microsoft.EntityFrameworkCore;
using GeographyQuiz.Models;

namespace GeographyQuiz.Data
{
    public class GeoContext : DbContext
    {
        public GeoContext(DbContextOptions<GeoContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }
    }
}
