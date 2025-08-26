using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities.Common;

public abstract class ComtradeCategories:Entity<Guid>
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string ParentId { get; set; } = null!;
    public string PrettyName { get; set; } = null!;
}