namespace shop.data.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Product
{

    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ObjectId GroupId { get; set; }
    public string Image { get; set; }
}
    