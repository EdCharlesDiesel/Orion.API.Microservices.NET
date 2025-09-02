using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Postgres.Strategy
{
    public interface IDaysInOfficeStrategy
    {
         int GetDaysInOffice(IEnumerable<Term> terms);
    }
}