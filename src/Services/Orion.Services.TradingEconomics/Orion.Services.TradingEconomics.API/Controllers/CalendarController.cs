using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Orion.Core.TradingEconomics.Domain;
using Orion.Services.TradingEconomics.API.Services;


namespace Orion.Services.TradingEconomics.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarServices _service;

        public CalendarController(ICalendarServices service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all comtrade categories
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            string result = await _service.GetCalendarEvents();

            List<CalendarEvent>? calendarEvents;
            try
            {
                calendarEvents = JsonSerializer.Deserialize<List<CalendarEvent>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (calendarEvents == null || !calendarEvents.Any())
                    return BadRequest("No calendar events found in the JSON.");
            }
            catch (JsonException ex)
            {
                return BadRequest($"JSON deserialization error: {ex.Message}");
            }

            await _service.Create(calendarEvents);

            return Ok(result);
        }

        // GET: api/calendar/daterange?startDate=2025-07-01&endDate=2025-07-31
        [HttpGet("daterange")]
        public async Task<IActionResult> GetEventsByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _service.GetCalendarEventsByDate(startDate, endDate);
            return Ok(result);
        }

        // GET: api/calendar/countries?names=South Africa,USA
        [HttpGet("countries")]
        public async Task<IActionResult> GetEventsByCountries([FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByCountries(names);
            return Ok(result);
        }

        // GET: api/calendar/countriesdaterange?startDate=2025-07-01&endDate=2025-07-31&names=USA,Germany
        [HttpGet("countriesdaterange")]
        public async Task<IActionResult> GetEventsByCountriesAndDates([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByCountriesAndDates(startDate, endDate, names);
            return Ok(result);
        }

        // GET: api/calendar/indicators?names=GDP,Inflation
        [HttpGet("indicators")]
        public async Task<IActionResult> GetEventsByIndicators([FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByIndicator(names);
            return Ok(result);
        }

    }


}