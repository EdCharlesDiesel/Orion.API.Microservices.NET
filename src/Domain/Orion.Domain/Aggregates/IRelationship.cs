using Orion.Domain.DTOs;
using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public interface IRelationship: IEntity<int>, IBaseEntity
    {
        void FullUpdate(IRelationshipFullEditDto o);

        int FromPersonId { get;}     

        int ToPersonId { get;}     

        string RelationshipType { get;}
    }   
}

 