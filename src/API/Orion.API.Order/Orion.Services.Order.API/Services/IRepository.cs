namespace Orion.Services.Order.API.Services;


    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<Core.Order.Domain.Order> AddAsync(T entity);
        Task<Core.Order.Domain.Order> UpdateAsync(T entity);
        Task DeleteAsync(object id);
    }

