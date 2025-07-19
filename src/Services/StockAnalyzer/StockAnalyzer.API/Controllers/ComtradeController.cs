using Microsoft.AspNetCore.Mvc;
using Orion.Services.StockAnalyzer.API.Helper;

namespace Orion.Services.StockAnalyzer.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ComtradeController :  ControllerBase
{

        /// <summary>
        /// Get all comtrade categories
        /// </summary>
        [HttpGet("categories")]
        public async Task<IActionResult> GetComCategories()
        {
            var result = await HttpRequesterClass.HttpRequester("/comtrade/categories");
            return Ok(result);
        }

        /// <summary>
        /// Get all comtrade countries
        /// </summary>
        [HttpGet("countries")]
        public async Task<IActionResult> GetComCountries()
        {
            var result = await HttpRequesterClass.HttpRequester("/comtrade/countries");
            return Ok(result);
        }

        /// <summary>
        /// Get comtrade by country and page
        /// </summary>
        [HttpGet("country/{country}/{page_number}")]
        public async Task<IActionResult> GetComCountryPage(string country, int page_number)
        {
            var result = await HttpRequesterClass.HttpRequester($"/comtrade/country/{country}/{page_number}");
            return Ok(result);
        }

        /// <summary>
        /// Get comtrade between two countries with pagination
        /// </summary>
        [HttpGet("country/{country1}/{country2}/{page_number}")]
        public async Task<IActionResult> GetComBetweenCountries(string country1, string country2, int page_number)
        {
            var result =
                await HttpRequesterClass.HttpRequester($"/comtrade/country/{country1}/{country2}/{page_number}");
            return Ok(result);
        }

        /// <summary>
        /// Get historical comtrade data by symbol
        /// </summary>
        [HttpGet("historical/{symbol}")]
        public async Task<IActionResult> GetComHistorical(string symbol)
        {
            var result = await HttpRequesterClass.HttpRequester($"/comtrade/historical/{symbol}");
            return Ok(result);
        }

    
}