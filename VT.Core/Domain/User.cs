namespace VT.Core.Domain;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
}
