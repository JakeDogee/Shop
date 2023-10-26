using MongoDB.Bson;

namespace shop.data.Entities;

public class User
{
    public ObjectId Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}