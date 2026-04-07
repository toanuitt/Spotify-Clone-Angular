using Spotify.Domain.Abstractions.Dappers.Repositories.Product;

namespace Spotify.Domain.Abstractions.Dappers;

public interface IUnitOfWork
{
        IProductRepository Products{ get; }
}
