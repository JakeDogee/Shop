using MongoDB.Bson;
using shop.data.Enums;

namespace shop.data.Entities;

public class Order
{
    public ObjectId Id { get; set; }
    public ObjectId UserId { get; set; }
    public OrderStatus Status { get; set; }
    public decimal TotalPrice { get; set; }
}