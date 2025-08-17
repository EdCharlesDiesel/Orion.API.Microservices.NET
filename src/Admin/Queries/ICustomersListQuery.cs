using Orion.Admin.Models.Customers;
using Orion.Admin.Tools;

namespace ORION.Admin.Queries
{
    public interface ICustomersListQuery: IQuery
    {
        Task<IEnumerable<CustomerInfosViewModel>> GetAllCustomers();
        
    }
}
