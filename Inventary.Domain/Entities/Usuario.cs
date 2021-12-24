namespace Inventary.Domain.Entities;

public class Usuario : EntityBase
{
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public string? Role { get; set; }
}