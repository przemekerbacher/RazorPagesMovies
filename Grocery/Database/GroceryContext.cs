using Grocery.Models;
using Microsoft.EntityFrameworkCore;

namespace Grocery.Database
{
    public class GroceryContext : DbContext
    {
        public GroceryContext(DbContextOptions<GroceryContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Product> DiscountedProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Grocery.Models.DiscountedProduct> DiscountedProduct { get; set; }
    }
}
