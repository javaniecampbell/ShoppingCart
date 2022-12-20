namespace ShoppingCart.Api.Data.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}