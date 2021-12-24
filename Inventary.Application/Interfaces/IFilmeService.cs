using Inventary.Application.DTOs;

namespace Inventary.Application.Interfaces;

public interface IFilmeService
{
    Task Adicionar(FilmeDto filmeDto);
    Task Deletar(int id);
    Task Atualizar(FilmeDto filmeDto);
    Task<IEnumerable<FilmeDto>> Obter();
    Task<FilmeDto?> ObterPorId(int id);
    Task<IEnumerable<FilmeDto>> ObterPorCategoria(string categoria);
}