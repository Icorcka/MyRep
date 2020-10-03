using Microsoft.EntityFrameworkCore;

namespace GuitarStore.Models
{
    public class GuitarStoreContext: DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public GuitarStoreContext(DbContextOptions<GuitarStoreContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
