using shop.api.Models.Requests;
using shop.api.Repository.Abstractions;
using shop.api.Services.Abstractions;
using shop.data.Entities;

namespace shop.api.Services;

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