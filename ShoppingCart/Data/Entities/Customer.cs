namespace ShoppingCart.Api.Data.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Cart Cart { get; set; }

    }
}
