namespace shop.data.Entities.Abstractions;

public class IdentitfiedEntity : BaseEntity<Guid>
{
    public override Guid Id => Guid.NewGuid();
}