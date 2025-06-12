namespace VT.Core.Shared.ModelViews.User;

public class UserDTO
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
}
