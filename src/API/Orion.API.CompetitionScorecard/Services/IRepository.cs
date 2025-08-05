using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.Services.CompetitionScorecard.API.Services;


    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<Coupon> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
    }

