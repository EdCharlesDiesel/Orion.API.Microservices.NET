using System;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IPersonBusiness: IEntity<int>, IBaseEntity
    {
        void FullUpdate(IPersonBusiness o);



       //  public Person Person { get; set; }
        string BusinessType { get; set; }
        string BusinessValue { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        
    }   
}