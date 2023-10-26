using MongoDB.Bson.Serialization.Attributes;
using shop.data.Entities.Abstractions;

namespace shop.data.Entities;

public class Group : IdentitfiedEntity
{
    [BsonElement("name")]
    public string Name { get; set; }
}