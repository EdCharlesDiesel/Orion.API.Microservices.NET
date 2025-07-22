using Microsoft.AspNetCore.Mvc;

namespace Orion.Services.StockAnalyzer.API.Controllers;
[ApiController]
[Route("api/[controller]")]

public class MarketsIntradayController : ControllerBase

{
        private readonly Orion.Services.StockAnalyzer.API.Services.TradingEconomicsService _service;

        public MarketsIntradayController(Orion.Services.StockAnalyzer.API.Services.TradingEconomicsService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get intraday prices for a single market symbol.
        /// </summary>
        [HttpGet("intraday/{symbol}")]
        public async Task<IActionResult> GetIntradaySymbol(string symbol)
        {
            var result = await _service.GetIntradaySymbolAsync(symbol);
            return Ok(result);
        }

        /// <summary>
        /// Get intraday prices by symbol and start date (hour).
        /// </summary>
        [HttpGet("intraday-datehour")]
        public async Task<IActionResult> GetIntradayDateHour([FromQuery] string symbol, [FromQuery] DateTime startDate)
        {
            var result = await _service.GetIntradayDateHourAsync(symbol, startDate);
            return Ok(result);
        }

        /// <summary>
        /// Get intraday data between two dates.
        /// </summary>
        [HttpGet("intraday-dates")]
        public async Task<IActionResult> GetIntradaySymbolDates([FromQuery] string symbol, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _service.GetIntradaySymbolDatesAsync(symbol, startDate, endDate);
            return Ok(result);
        }
    }

