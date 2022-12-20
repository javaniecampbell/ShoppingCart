using ShoppingCart.Api.DTOs;

namespace ShoppingCart.Api.Services
{
    public interface ICartService
    {
        CartDTO CreateCartFor(string customerId);
        bool Checkout(string customerId);
    }
}