using MongoDB.Bson.Serialization.Attributes;
using shop.data.Entities.Abstractions;

namespace shop.data.Entities;

public class User : IdentitfiedEntity
{
    [BsonElement("userName")]
    public string FullName { get; set; }
    
    [BsonElement("phone")]
    public string Phone { get; set; }
    
    [BsonElement("email")]
    public string Email { get; set; }
}