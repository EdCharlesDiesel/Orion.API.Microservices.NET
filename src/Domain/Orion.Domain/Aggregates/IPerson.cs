using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IPerson: IEntity<int>, IBaseEntity
    {
        void FullUpdate(IPersonFullEditDto o);

        string FirstName { get; set; }

        string LastName { get; set; }
        
    }   
}

 