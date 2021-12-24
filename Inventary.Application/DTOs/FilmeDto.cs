namespace Inventary.Application.DTOs;

public class FilmeDto
{
    public int Id { get; set; }
    public string? Categoria { get; set; }
    public string? Identificacao { get; set; }
    public int FaixaEtaria { get; set; }
    public double Duracao { get; set; }
    public DateTime CriadoEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
}