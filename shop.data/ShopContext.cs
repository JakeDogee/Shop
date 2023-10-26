using MongoDB.Driver;
using shop.data.Abstractions;
using shop.data.Configurations;
using shop.data.Entities;

namespace shop.data;

public class ShopContext : MongoDbContext
{
    public ShopContext(MongoDbContextOptions options) : base(options)
    {
    }

    public IMongoCollection<Group> Groups { get; set; }

    public IMongoCollection<Order> Orders { get; set; }

    public IMongoCollection<Product> Products { get; set; }

    public IMongoCollection<User> Users { get; set; }

    public override async Task MigrateAsync()
    {
        await base.MigrateAsync();
    }
}