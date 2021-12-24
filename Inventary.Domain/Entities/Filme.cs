namespace Inventary.Domain.Entities;

public class Filme : EntityBase
{
    public string? Categoria { get; set; }
    public string? Identificacao { get; set; }
    public int FaixaEtaria { get; set; }
    public double Duracao { get; set; }
}