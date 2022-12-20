namespace ShoppingCart.Api.DTOs
{
    public class CartDTO
    {
        public CartDTO()
        {

        }

        public CartDTO(Guid id, Guid customerId)
        {
            Id = id;
            CustomerId = customerId;
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
    }
}
