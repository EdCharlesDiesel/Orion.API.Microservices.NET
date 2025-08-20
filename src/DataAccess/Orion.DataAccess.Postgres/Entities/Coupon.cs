

using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities;
public class Coupon:Entity<Guid>
{

    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}