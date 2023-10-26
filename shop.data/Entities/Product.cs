using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using shop.data.Entities.Abstractions;

namespace shop.data.Entities;

public class Product : IdentitfiedEntity
{
    [BsonElement("name")]
    public string Name { get; set; }
    
    [BsonElement("price")]
    public decimal Price { get; set; }

    [BsonElement("groupId")]
    public string GroupId { get; set; }

    [BsonElement("image")]
    public string Image { get; set; }
}