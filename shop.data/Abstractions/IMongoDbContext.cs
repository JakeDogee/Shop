using MongoDB.Driver;

namespace shop.data.Abstractions;

public interface IMongoDbContext
{
    IMongoDatabase Database { get; }

    Task MigrateAsync();
}