using shop.api.Models.Requests;

namespace shop.api.Services.Abstractions;

public interface IProductService
{
    Task CreateAsync(CreateProductModelRequest modelRequest);
}