using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using shop.data.Entities.Abstractions;
using shop.data.Enums;

namespace shop.data.Entities;

public class Order : IdentitfiedEntity
{
    [BsonElement("userId")]
    public string UserId { get; set; }
    
    [BsonElement("status")]
    public OrderStatus Status { get; set; }
    
    [BsonElement("totalPrice")]
    public decimal TotalPrice { get; set; }
}