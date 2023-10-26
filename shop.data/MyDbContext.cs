using System.Data.Entity;
using MongoDB.Driver;
using shop.data.Entities;

namespace shop.data;

public class MyDbContext : MongoDbContext
{
    
    
    public static void Configure()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("Shop");
        var groupCollection = database.GetCollection<Group>("Group");
        var orderCollection = database.GetCollection<Order>("Order");
        var productCollection = database.GetCollection<Product>("Product");
        var userCollection = database.GetCollection<User>("User");
    }
}