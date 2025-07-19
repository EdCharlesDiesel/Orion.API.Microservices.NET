
using Microsoft.AspNetCore.Mvc;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Web.Controllers;

public class CalendarController : Controller
{

        private static readonly List<Calendar> _calendarEvents = new()
        {
            new Calendar { Id = Guid.NewGuid(), EventName = "GDP Release", Date = DateTime.Now.AddDays(1) },
            new Calendar { Id = Guid.NewGuid(), EventName = "Unemployment Report", Date = DateTime.Now.AddDays(3) }
        };

        // GET: /Calendar
        public IActionResult Index()
        {
            return View(_calendarEvents);
        }

        // GET: /Calendar/Details/{id}
        public IActionResult Details(Guid id)
        {
            var item = _calendarEvents.FirstOrDefault(c => c.Id == id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // GET: /Calendar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Calendar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Calendar calendar)
        {
            if (ModelState.IsValid)
            {
                calendar.Id = Guid.NewGuid();
                _calendarEvents.Add(calendar);
                return RedirectToAction(nameof(Index));
            }
            return View(calendar);
        }

        // GET: /Calendar/Edit/{id}
        public IActionResult Edit(Guid id)
        {
            var item = _calendarEvents.FirstOrDefault(c => c.Id == id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // POST: /Calendar/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, Calendar updated)
        {
            var item = _calendarEvents.FirstOrDefault(c => c.Id == id);
            if (item == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                item.EventName = updated.EventName;
                item.Date = updated.Date;
                return RedirectToAction(nameof(Index));
            }

            return View(updated);
        }

        // GET: /Calendar/Delete/{id}
        public IActionResult Delete(Guid id)
        {
            var item = _calendarEvents.FirstOrDefault(c => c.Id == id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // POST: /Calendar/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var item = _calendarEvents.FirstOrDefault(c => c.Id == id);
            if (item != null)
            {
                _calendarEvents.Remove(item);
            }
            return RedirectToAction(nameof(Index));
        }
}