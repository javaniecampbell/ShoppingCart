using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Api.DTOs;
using ShoppingCart.Api.Services;
using ShoppingCart.Controllers;

namespace ShoppingCart.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Return_EmptyCart_WithId()
        {
            CartsController sut = new CartsController(new CartService());
            string customerId = Guid.NewGuid().ToString();
            var actual =  sut.Get(customerId) as OkObjectResult;
            CartDTO cart = actual?.Value as CartDTO;  
            Assert.IsNotNull(cart);
            Assert.IsNotNull(cart?.Id);
        }
    }
}