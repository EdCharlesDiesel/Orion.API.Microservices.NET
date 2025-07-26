using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class ForecastController : ControllerBase
    {
        private readonly IForecastServices _service;

        public ForecastController(IForecastServices service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all comtrade categories
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllForecasts()
        {
            var result = await _service.GetForecasts();

            List<Forecast>? forecasts;
            try
            {
                forecasts = JsonSerializer.Deserialize<List<Forecast>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (forecasts == null || !forecasts.Any())
                    return BadRequest("No calendar events found in the JSON.");
            }
            catch (JsonException ex)
            {
                return BadRequest($"JSON deserialization error: {ex.Message}");
            }

            await _service.Create(forecasts);

            return Ok(result);
        }

        // GET: api/calendar/daterange?startDate=2025-07-01&endDate=2025-07-31
        [HttpGet("daterange")]
        public async Task<IActionResult> GetEventsByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _service.GetForecastsByDate(startDate, endDate);
            return Ok(result);
        }

        // GET: api/calendar/countries?names=South Africa,USA
        [HttpGet("countries")]
        public async Task<IActionResult> GetEventsByCountries([FromQuery] string[] names)
        {
            var result = await _service.GetForecastsByCountries(names);
            return Ok(result);
        }

        // GET: api/calendar/countriesdaterange?startDate=2025-07-01&endDate=2025-07-31&names=USA,Germany
        [HttpGet("countriesdaterange")]
        public async Task<IActionResult> GetEventsByCountriesAndDates([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string[] names)
        {
            var result = await _service.GetForecastsByCountriesAndDates(startDate, endDate, names);
            return Ok(result);
        }

        // GET: api/calendar/indicators?names=GDP,Inflation
        [HttpGet("indicators")]
        public async Task<IActionResult> GetEventsByIndicators([FromQuery] string[] names)
        {
            var result = await _service.GetForecastsByIndicator(names);
            return Ok(result);
        }

    }
