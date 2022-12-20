using ShoppingCart.Api.DTOs;
using ShoppingCart.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    
    public class CartServiceTests
    {

        [Test]
        public void Should_Return_A_Cart_Given_A_Customers_Id()
        {
            CartService sut = new CartService();
            string customerId = Guid.NewGuid().ToString();
           CartDTO cart =  sut.CreateCartFor(customerId);
            Assert.AreEqual(Guid.Parse(customerId), cart.CustomerId);

        }
    }
}
