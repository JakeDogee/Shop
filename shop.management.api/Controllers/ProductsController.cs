using Microsoft.AspNetCore.Mvc;

namespace shop.management.api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync()
    {
        return Ok();
    }
}