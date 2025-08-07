using Orion.Core.Discount.Domain;

namespace Orion.Repository.Services.Orion
{
    public interface IDiscountRepository : IRepository<Coupon>
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
    }
}