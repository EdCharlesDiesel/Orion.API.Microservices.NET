using Microsoft.AspNetCore.Mvc;

namespace Orion.API.TradingEconomics.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class EmuController : ControllerBase
    {
        [HttpGet("simulate")]
        public IActionResult SimulateEmuCycle()
        {
            var emu = new EMU();

            // Add member countries
            emu.MemberStates.Add(new Country { Name = "Germany", BudgetDeficit = 2.5, DebtToGDP = 58, NeedsMonetaryFlexibility = false });
            emu.MemberStates.Add(new Country { Name = "France", BudgetDeficit = 3.8, DebtToGDP = 65, NeedsMonetaryFlexibility = true });
            emu.MemberStates.Add(new Country { Name = "Italy", BudgetDeficit = 4.2, DebtToGDP = 75, NeedsMonetaryFlexibility = true });

            // ECB economic indicators
            emu.ECB.InflationRate = 2.3;
            emu.ECB.GDPGrowth = 0.9;

            // Simulate EMU
            emu.RunYearlyCycle();
            emu.EvaluateSouthAfricaImpact();

            return Ok("EMU simulation completed. Check logs for detailed output.");
        }
    
}