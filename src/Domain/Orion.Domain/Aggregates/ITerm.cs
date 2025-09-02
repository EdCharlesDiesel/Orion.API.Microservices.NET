using System;
using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface ITerm: IEntity<int>, IBaseEntity
    {
        void FullUpdate(ITermFullEditDto o);   
     
        bool IsDeleted { get;}

        string Role { get; }

        DateTime StartOfTerm { get;  }
        
        DateTime EndOfTerm { get; set; }
        
        int NumberOfTerms { get; set; }

        int BusinessOwnerId { get; }
   
    }
}
