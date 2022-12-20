using ShoppingCart.Api.Data.Entities;

namespace ShoppingCart.Api.Repositories
{
    public interface ICartRepository
    {
        Cart GetCart(Guid id);
        void CreateCart(Cart cart);
    }
}
