namespace Capture.Domain.Repositories;

public interface IRepository<T> where T : class
{
    public Task<T> CreateAsync(T entity);

    public Task<bool> DeleteAsync(T entity);

    public Task<T> UpdateAsync(T entity);

    public Task<T> GetAsync(Guid id);

    public Task<ICollection<T>> GetAllAsync();
}