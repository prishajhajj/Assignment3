using Microsoft.EntityFrameworkCore;
using Webly_Backend.Models.Entities;

namespace Webly_Backend.Models.Database
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Image> Images { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
