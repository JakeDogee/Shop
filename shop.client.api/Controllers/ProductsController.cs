using Microsoft.AspNetCore.Mvc;
using shop.client.api.Repository;
using shop.client.api.Models.Requests;
using shop.client.api.Services.Abstractions;
using shop.data.Entities;

namespace shop.client.api.Controllers;

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