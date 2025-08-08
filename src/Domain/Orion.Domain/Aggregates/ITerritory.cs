using System.Collections.Generic;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface ITerritory : IEntity<int>, IBaseEntity
    {
        void FullUpdate(ITerritory o);

        string TerritoryDescription { get; }

        int RegionId { get; }

        //FIXME Need to investagate

        // IRegion Region { get; }

        // IEnumerable<IEmployeeTerritory> Employees { get; }

    }
}
