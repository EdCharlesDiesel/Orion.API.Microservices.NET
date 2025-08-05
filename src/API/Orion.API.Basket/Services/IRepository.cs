using Orion.Services.Basket.API.DTO;

namespace Orion.Services.Basket.API.Services;


    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<Core.Basket.Domain.Basket?> GetByIdAsync(Guid id);
        Task<BasketDto?> AddAsync(BasketDto basket);
        Task UpdateAsync(Core.Basket.Domain.Basket entity);
        Task DeleteAsync(Guid id);
    }

