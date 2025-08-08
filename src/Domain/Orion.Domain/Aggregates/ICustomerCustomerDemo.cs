using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface ICustomerCustomerDemo: IEntity<int>, IBaseEntity
    {
        void FullUpdate(ICustomerCustomerDemoFullEditDto o);
  
        int CustomerId { get; }   
    }
}
