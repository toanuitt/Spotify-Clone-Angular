using Microsoft.Extensions.DependencyInjection;
using Spotify.Domain.Abstractions.Dappers;
using Spotify.Domain.Abstractions.Dappers.Repositories.Product;
using Spotify.Infrastructure.Repositories;

namespace Spotify.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructureDapper(this IServiceCollection services)
       => services.AddTransient<IProductRepository, ProductRepository>()
           .AddTransient<IUnitOfWork, UnitOfWork>();
}
