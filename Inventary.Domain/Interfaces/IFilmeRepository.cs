using Inventary.Domain.Entities;

namespace Inventary.Domain.Interfaces;

public interface IFilmeRepository
{
    Task Adicionar(Filme filme);
    Task Deletar(int id);
    Task Atualizar(Filme filme);
    Task<IEnumerable<Filme>> Obter();
    Task<Filme?> ObterPorId(int id);
    Task<IEnumerable<Filme>> ObterPorCategoria(string categoria);
}