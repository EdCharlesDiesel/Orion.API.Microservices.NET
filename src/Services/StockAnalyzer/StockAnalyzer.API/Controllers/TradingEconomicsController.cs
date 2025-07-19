using Microsoft.AspNetCore.Mvc;

namespace Orion.Services.StockAnalyzer.API.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class TradingEconomicsController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TradingEconomicsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("indicators")]
        public async Task<IActionResult> GetIndicators()
        {
            var client = _httpClientFactory.CreateClient();
            var url = "https://api.tradingeconomics.com/indicators?c=guest:guest";

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return Ok(content); // returns raw JSON
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, $"Error calling Trading Economics: {ex.Message}");
            }
        }
    }
