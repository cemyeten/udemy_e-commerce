
using API.data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.data.DataContext
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }    

    
}
