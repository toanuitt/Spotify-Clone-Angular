namespace Spotify.Domain.Abstractions.Dappers;

public interface IUnitOfWork
{
        IProductRepository ProductRepository { get; }
}
