using Microsoft.AspNetCore.Mvc;
using shop.api.Models.Requests;
using shop.api.Repository;
using shop.api.Services.Abstractions;
using shop.data.Entities;

namespace shop.api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateProductModelRequest request)
    {
        await _service.CreateAsync(request);
        return Ok();
    }
}