using System.Collections.Generic;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface ICustomerDemographic: IEntity<int>, IBaseEntity
    {
        void FullUpdate(ICustomerDemographic o);
        
        string CustomerDescrition { get;}

              
    }
}
