namespace TF.Core.Shared.ModelViews.Conta;

public class UserDTO
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
}
