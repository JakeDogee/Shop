using shop.data;
using shop.data.Configurations;

namespace shop.management.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var options = configuration.GetSection("shopDb").Get<MongoDbContextOptions>();
        serviceCollection.AddSingleton(options);
        serviceCollection.AddScoped<ShopContext>();

        return serviceCollection;
    }
}