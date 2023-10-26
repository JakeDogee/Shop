namespace shop.api.Models.Requests;

public class CreateProductModelRequest
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public string GroupId { get; set; }

    public string Image { get; set; }
}