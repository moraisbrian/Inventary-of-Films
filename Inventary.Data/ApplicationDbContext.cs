using Inventary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventary.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
    {
    }

    public DbSet<Filme>? Filmes { get; set; }
}
