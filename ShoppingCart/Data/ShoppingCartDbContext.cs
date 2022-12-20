using Microsoft.EntityFrameworkCore;
using ShoppingCart.Api.Data.Entities;

namespace ShoppingCart.Api.Data
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext()
            : base("name=DefaultConnnection")
        {
        }
        public ShoppingCartDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
