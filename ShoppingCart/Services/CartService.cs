using ShoppingCart.Api.DTOs;
using ShoppingCart.Api.Repositories;

namespace ShoppingCart.Api.Services
{
    public class CartService : ICartService
    {
        // 
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository){
            _cartRepository= cartRepository;
        }

        public bool Checkout(string customerId)
        {
            throw new NotImplementedException();
        }

        public CartDTO CreateCartFor(string customerId)
        {
            return new CartDTO(Guid.NewGuid(), Guid.Parse(customerId));
        }
    }
}
