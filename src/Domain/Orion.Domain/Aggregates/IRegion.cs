using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IRegion: IEntity<int>, IBaseEntity
    {
        void FullUpdate(IRegion o);

        string RegionDescription { get;}
     
    }  
}
