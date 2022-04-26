using Microsoft.EntityFrameworkCore;
using StoreDotNetCoreAPI.Entities;

namespace StoreDotNetCoreAPI.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // Products will never be null, because EF will automatically set it, but need to tell compiler that, hence `=null!`.
        public DbSet<Product> Products { get; set; } = null!;
    }
}
