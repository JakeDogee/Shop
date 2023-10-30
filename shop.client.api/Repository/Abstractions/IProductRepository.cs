using shop.data.Entities;

namespace shop.client.api.Repository.Abstractions;

public interface IProductRepository
{
    public Task CreateAsync(Product entity);
}