using System;
using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IOrderDetail: IEntity<int>, IBaseEntity
    {
        void FullUpdate(IOrderDetailFullEditDto o);
      
        int OrderId { get; set; }

        int ProductId { get; set; }

        decimal UnitPrice { get; set; }

        short Quantity { get; set; }

        Single Discount { get; set; }       
    }
}
