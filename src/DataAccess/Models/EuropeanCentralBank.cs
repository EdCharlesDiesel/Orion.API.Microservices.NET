using System;

namespace Orion.DataAccess.Models;

public class EuropeanCentralBank
{
    public double InflationRate { get; set; }
    public double GDPGrowth { get; set; }

    public void ApplyMonetaryPolicy()
    {
        if (InflationRate > 2.0)
        {
            Console.WriteLine("ECB increases interest rates to control inflation.");
        }
        else if (GDPGrowth < 1.0)
        {
            Console.WriteLine("ECB lowers interest rates to stimulate growth.");
        }
        else
        {
            Console.WriteLine("ECB maintains interest rates to preserve price stability.");
        }
    }
}