using Inventary.Data.Seeders;
using Inventary.Domain.Entities;
using Inventary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventary.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UsuarioRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        new UsuarioSeeder(_dbContext).Seed();
    }

    public async Task<Usuario?> Autenticar(Usuario usuario)
    {
        return await _dbContext.Usuarios!.FirstOrDefaultAsync(x => x.Email == usuario.Email && x.Senha == usuario.Senha);
    }
}