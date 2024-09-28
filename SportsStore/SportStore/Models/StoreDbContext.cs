using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;

namespace SportStore.Models
{
    public class StoreDbContext : DbContext
    {
        //public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public StoreDbContext() { }

        public DbSet<Product> Products { get; set; }
    }

}
