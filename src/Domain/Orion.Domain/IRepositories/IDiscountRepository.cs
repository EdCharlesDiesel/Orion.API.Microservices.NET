using System.Threading.Tasks;

namespace Orion.Domain.IRepositories
{
    public interface IDiscountRepository : IRepository<Coupon>
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
    }

    public class Coupon
    {
    }
}