using MongoDB.Driver;
using shop.api.Repository.Abstractions;
using shop.data;
using shop.data.Entities;

namespace shop.api.Repository;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<Product> _mongoCollection;

    public ProductRepository(ShopContext context)
    {
        _mongoCollection = context.Products;
    }

    public Task CreateAsync(Product entity)
    {
        return _mongoCollection.InsertOneAsync(entity);
    }
}