
using Microsoft.AspNetCore.Mvc;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.WebApps.Web.Controllers;

public class CalendarController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CalendarController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    // GET: /Calendar
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("https://api.example.com/data");

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            ViewBag.ApiResult = result;
            return View();
        }

        ViewBag.ApiResult = "Error: " + response.StatusCode;
        return View();
    }

        // GET: /Calendar/Details/{id}
        public IActionResult Details(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://api.example.com/data");
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