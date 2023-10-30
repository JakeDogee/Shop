using shop.client.api.Models.Requests;
using shop.client.api.Repository.Abstractions;
using shop.client.api.Services.Abstractions;
using shop.data.Entities;

namespace shop.client.api.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task CreateAsync(CreateProductModelRequest modelRequest)
    {
        var entity = new Product
        {
            Name = modelRequest.Name,
            Price = modelRequest.Price,
            GroupId = modelRequest.GroupId,
            Image = modelRequest.Image
        };

        return _productRepository.CreateAsync(entity);
    }
}