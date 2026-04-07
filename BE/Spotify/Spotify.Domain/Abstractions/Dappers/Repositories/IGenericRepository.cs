namespace Spotify.Domain.Abstractions.Dappers.Repositories;

public interface IGenericRepository<Tkey, T> where T:class
{
    Task<T?> GetByIdAsync(Tkey id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<int> AddAsync(T entity);
    Task<int> UpdateAsync(T entity);
    Task<int> DeleteAsync(Tkey id);
}
