using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface ICustomerEventRepository
    {
        void New(CustomerEventType deleted, object evCustomerId, object evOldVersion);
    }
}