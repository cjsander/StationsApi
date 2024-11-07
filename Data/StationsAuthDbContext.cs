using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Stations.API.Data
{
    public class StationsAuthDbContext : IdentityDbContext
    {
        public StationsAuthDbContext(DbContextOptions<StationsAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //SEED NEW ROLES
            base.OnModelCreating(builder);
            var readerRoleId = "34e3d61c-eaf2-424d-925f-ddfa8f6ccfbb";
            var writerRoleId = "9df87ffb-edfe-44b0-a948-6fdf73431e9e";

            var roles = new List<IdentityRole> {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()

                },
                 new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
                };
            builder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
