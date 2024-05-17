using E_Commerce.Presentation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(ApiRoute.Products.GetAll)]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}