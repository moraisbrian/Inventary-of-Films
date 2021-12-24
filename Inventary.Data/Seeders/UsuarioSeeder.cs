using Inventary.Domain.Entities;

namespace Inventary.Data.Seeders;

public class UsuarioSeeder
{
    private readonly ApplicationDbContext _dbContext;

    public UsuarioSeeder(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if (!_dbContext.Usuarios!.Any())
        {
            _dbContext.Usuarios!.AddRange(new Usuario[]
            {
                new Usuario
                {
                    AtualizadoEm = DateTime.Now,
                    CriadoEm = DateTime.Now,
                    Email = "admin@email.com",
                    Senha = "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92",
                    Role = "Admin"
                },
                new Usuario
                {
                    AtualizadoEm = DateTime.Now,
                    CriadoEm = DateTime.Now,
                    Email = "user@email.com",
                    Senha = "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92",
                    Role = "User"
                }
            });

            _dbContext.SaveChanges();
        }
    }
}