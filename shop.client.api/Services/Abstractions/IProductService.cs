using shop.client.api.Models.Requests;

namespace shop.client.api.Services.Abstractions;

public interface IProductService
{
    Task CreateAsync(CreateProductModelRequest modelRequest);
}