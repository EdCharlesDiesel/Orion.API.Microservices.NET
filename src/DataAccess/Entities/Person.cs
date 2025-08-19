using System;
using System.Collections.Generic;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Entities;

public partial class Person: IEntity<int>
{
    public int Id { get; }
    public bool IsTransient()
    {
        throw new NotImplementedException();
    }

    public List<IEventNotification> DomainEvents { get; }
    public void AddDomainEvent(IEventNotification evt)
    {
        throw new NotImplementedException();
    }

    public void RemoveDomainEvent(IEventNotification evt)
    {
        throw new NotImplementedException();
    }
}