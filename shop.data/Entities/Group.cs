using MongoDB.Bson;

namespace shop.data.Entities;

public class Group
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
}