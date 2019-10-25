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
    }
}
