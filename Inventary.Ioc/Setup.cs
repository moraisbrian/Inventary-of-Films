using Inventary.Application;
using Inventary.Application.Interfaces;
using Inventary.Application.Services;
using Inventary.Data;
using Inventary.Data.Repositories;
using Inventary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Inventary.Ioc;
public static class Setup
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Database"));

        services.AddAutoMapper(typeof(AutoMapperSetup));

        services.AddScoped<IFilmeRepository, FilmeRepository>();
        services.AddScoped<IFilmeService, FilmeService>();
    }
}
