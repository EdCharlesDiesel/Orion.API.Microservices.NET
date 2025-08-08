using System.Collections.Generic;
using Orion.DataAccess.Models;


namespace Orion.DataAccess.Strategy
{
    public interface IDaysInOfficeStrategy
    {
         int GetDaysInOffice(IEnumerable<Term> terms);
    }
}