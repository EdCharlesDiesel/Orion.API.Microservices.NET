using System;

namespace Orion.DataAccess.Models;

public class Country
{

        public string Name { get; set; }
        public double BudgetDeficit { get; set; } // % of GDP
        public double DebtToGDP { get; set; } // % of GDP
        public bool NeedsMonetaryFlexibility { get; set; }

        public void TakeCorrectiveAction()
        {
            if (BudgetDeficit > 3.0)
            {
                Console.WriteLine($"{Name} exceeds 3% budget deficit. Taking corrective fiscal action...");
            }

            if (DebtToGDP > 60.0)
            {
                Console.WriteLine($"{Name} exceeds 60% debt-to-GDP ratio. Implementing debt control measures...");
            }
        }

        public void SubmitEconomicPlan()
        {
            Console.WriteLine($"{Name} submitted economic policy plan to EMU Council.");
        }
    
}