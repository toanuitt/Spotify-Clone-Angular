namespace Spotify.Domain.Abstractions.Dappers.Repositories;

public interface IGenericRepository<Tkey, T> where T:class
{
    Task<T?> GetByIdAsync(Tkey id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<Tkey> AddAsync(T entity);
    Task<Tkey> UpdateAsync(T entity);
    Task<Tkey> DeleteAsync(Tkey id);
}
