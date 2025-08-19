using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IShipper: IEntity<int>, IBaseEntity
    {

        void FullUpdate(IShipperFullEditDto o);
            
        string CompanyName { get; set; }

        string Phone { get; set; }

     //   int OrderId { get;} 
  
    }
}
