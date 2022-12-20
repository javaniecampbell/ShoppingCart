using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Api.DTOs;
using ShoppingCart.Api.Services;

namespace ShoppingCart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartsController : ControllerBase
    {
        private readonly ILogger<CartsController> _logger;
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;

            //_logger = logger;
        }

        [HttpGet(Name = "cart")]
        public IActionResult Get(string customerId)
        {
            string cartId = Guid.NewGuid().ToString();
            CartDTO cart = _cartService.CreateCartFor(customerId);
            return Ok(cart);
        }
    }
}