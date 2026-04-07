using Spotify.Domain.Abstractions.Dappers;
using Spotify.Domain.Abstractions.Dappers.Repositories.Product;

namespace Spotify.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IProductRepository productRepository)
    {
        Products = productRepository;
    }

    public IProductRepository Products { get; }
}
