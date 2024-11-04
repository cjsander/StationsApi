using Microsoft.EntityFrameworkCore;
using Stations.API.Models.Domain;

namespace Stations.API.Data
{
    public class StationsDbContext : DbContext
    {

        public StationsDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {


        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<PathRoute> PathRouters { get; set; }


    }
}
