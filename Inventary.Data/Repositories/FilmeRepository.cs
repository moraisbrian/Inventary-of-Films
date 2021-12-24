using Inventary.Data.Seeders;
using Inventary.Domain.Entities;
using Inventary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventary.Data.Repositories;

public class FilmeRepository : IFilmeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public FilmeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        new FilmeSeeder(_dbContext).Seed();
    }

    public async Task Adicionar(Filme filme)
    {
        await _dbContext.Filmes!.AddAsync(filme);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Atualizar(Filme filme)
    {
        var toChange = await _dbContext.Filmes!.FirstOrDefaultAsync(x => x.Id == filme.Id);

        if (toChange != null)
        {
            toChange.Identificacao = filme.Identificacao;
            toChange.AtualizadoEm = DateTime.Now;
            toChange.Categoria = filme.Categoria;
            toChange.Duracao = filme.Duracao;
            
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Deletar(int id)
    {
        var toDelete = await _dbContext.Filmes!.FirstOrDefaultAsync(x => x.Id == id);

        if (toDelete != null)
        {
            _dbContext.Filmes!.Remove(toDelete);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Filme>> Obter()
    {
        return await _dbContext.Filmes!.ToListAsync();
    }

    public async Task<IEnumerable<Filme>> ObterPorCategoria(string categoria)
    {
        return await _dbContext.Filmes!.Where(x => x.Categoria == categoria).ToListAsync();
    }

    public async Task<Filme?> ObterPorId(int id)
    {
        return await _dbContext.Filmes!.FirstOrDefaultAsync(x => x.Id == id);
    }
}