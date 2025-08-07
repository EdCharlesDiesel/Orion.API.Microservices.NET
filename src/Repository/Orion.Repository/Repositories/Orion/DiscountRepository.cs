using Microsoft.EntityFrameworkCore;
using Orion.Core.Discount.Domain;
using Orion.Repository.Services;
using Orion.Repository.Services.Orion;

namespace Orion.Repository.Repositories.Orion
{
    public class DiscountRepository(DbContext context) : IDiscountRepository
    {
        public async Task<Coupon> GetDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
