using System;
using System.Collections.Generic;
using System.Linq;
using Orion.DataAccess.Entities;

namespace Orion.DataAccess.Strategy
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
