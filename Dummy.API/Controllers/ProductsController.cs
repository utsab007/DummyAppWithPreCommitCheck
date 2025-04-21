using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dummy.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public List<string> products = new List<string>
        {
            "Product 1",
            "Product 2",
            "Product 3"
        };

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }
    }
}
