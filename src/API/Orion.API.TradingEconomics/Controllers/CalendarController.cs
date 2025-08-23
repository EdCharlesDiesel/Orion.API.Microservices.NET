using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Orion.DataAccess.Postgres.Entities;
using Orion.Domain.IRepositories;

namespace Orion.API.TradingEconomics.Controllers
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
        /// Get all calendar events
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

        /// <summary>
        /// Get calendar events by date range
        /// </summary>
        [HttpGet("daterange")]
        public async Task<IActionResult> GetEventsByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _service.GetCalendarEventsByDate(startDate, endDate);
            return Ok(result);
        }

        /// <summary>
        /// Get calendar events by country names
        /// </summary>
        [HttpGet("countries")]
        public async Task<IActionResult> GetEventsByCountries([FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByCountries(names);
            return Ok(result);
        }

        /// <summary>
        /// Get calendar events by countries and date range
        /// </summary>
        [HttpGet("countriesdaterange")]
        public async Task<IActionResult> GetEventsByCountriesAndDates(
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate,
            [FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByCountriesAndDates(startDate, endDate, names);
            return Ok(result);
        }

        /// <summary>
        /// Get calendar events by indicator names
        /// </summary>
        [HttpGet("indicators")]
        public async Task<IActionResult> GetEventsByIndicators([FromQuery] string[] names)
        {
            var result = await _service.GetCalendarEventsByIndicators(names);
            return Ok(result);
        }
    }

    public interface ICalendarServices
    {
        Task Create(List<CalendarEvent> calendarEvents);
        Task<object?> GetCalendarEventsByIndicators(string[] names);
        Task<object?> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, string[] names);
        Task<object?> GetCalendarEventsByDate(DateTime startDate, DateTime endDate);
        Task<object?> GetCalendarEventsByCountries(string[] names);
        Task<string> GetCalendarEvents();
    }
}
