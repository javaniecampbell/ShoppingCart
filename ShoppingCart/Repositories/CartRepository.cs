using Microsoft.EntityFrameworkCore;
using ShoppingCart.Api.Data;
using ShoppingCart.Api.Data.Entities;

namespace ShoppingCart.Api.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ShoppingCartDbContext _dbContext;
        public CartRepository() {
            _dbContext = new ShoppingCartDbContext();
        }
        public Cart GetCart(Guid id)
        {
          return _dbContext.Carts.Find(id);
        }
    }
}
