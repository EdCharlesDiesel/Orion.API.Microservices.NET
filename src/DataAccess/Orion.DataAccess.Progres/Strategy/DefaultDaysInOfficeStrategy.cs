using Orion.DataAccess.Entities;
using Orion.DataAccess.Progres.Entities;

namespace Orion.DataAccess.Progres.Strategy
{
    public class DefaultDaysInOfficeStrategy : IDaysInOfficeStrategy
    {
        public int GetDaysInOffice(IEnumerable<Term> terms)
        {
            var enumerable = terms as Term[] ?? terms.ToArray();
            if (!enumerable.Any())
            {
                return 0;
            }

            int totalDays = 0;

            foreach (var term in enumerable)
            {
                var diff = term.EndOfTerm - term.StartOfTerm;

                totalDays += Convert.ToInt32(diff.TotalDays);
            }

            return totalDays;
        }
    }
}
