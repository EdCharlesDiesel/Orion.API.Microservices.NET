using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarController : ControllerBase
    {
        private static readonly List<Calendar> _calendarEvents = new()
        {
            new Calendar { Id = Guid.NewGuid(), EventName = "GDP Release", Date = DateTime.Now.AddDays(1) },
            new Calendar { Id = Guid.NewGuid(), EventName = "Unemployment Data", Date = DateTime.Now.AddDays(3) }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Calendar>> GetAll()
        {
            return Ok(_calendarEvents);
        }

        [HttpGet("{id}")]
        public ActionResult<Calendar> GetById(Guid id)
        {
            var item = _calendarEvents.Find(c => c.Id == id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<Calendar> Create(Calendar calendar)
        {
            // calendar.Id = _calendarEvents.Count + 1;
            calendar.Id = Guid.NewGuid();
            _calendarEvents.Add(calendar);
            return CreatedAtAction(nameof(GetById), new { id = calendar.Id }, calendar);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Calendar calendar)
        {
            var existing = _calendarEvents.Find(c => c.Id == id);
            if (existing == null)
                return NotFound();

            existing.EventName = calendar.EventName;
            existing.Date = calendar.Date;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var item = _calendarEvents.Find(c => c.Id == id);
            if (item == null)
                return NotFound();

            _calendarEvents.Remove(item);
            return NoContent();
        }
    }
}