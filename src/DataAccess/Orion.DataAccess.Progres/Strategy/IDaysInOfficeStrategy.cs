using Orion.DataAccess.Entities;
using Orion.DataAccess.Progres.Entities;

namespace Orion.DataAccess.Progres.Strategy
{
    public interface IDaysInOfficeStrategy
    {
         int GetDaysInOffice(IEnumerable<Term> terms);
    }
}