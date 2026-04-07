namespace Spotify.Domain.Abstractions;

public interface IUnitOfWork : IDisposable
{
    /// <summary>
    /// Call save change from db context
    /// </summary>
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
