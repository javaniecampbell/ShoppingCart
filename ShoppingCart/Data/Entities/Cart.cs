namespace ShoppingCart.Api.Data.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public List<CartItem> Items { get; set; }

    }
}
