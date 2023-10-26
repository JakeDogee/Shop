using shop.data.Entities;

namespace shop.api.Repository.Abstractions;

public interface IProductRepository
{
    public Task CreateAsync(Product entity);
}