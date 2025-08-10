using Orion.API.HumanResources.Business;
using Orion.API.HumanResources.Models;

namespace Orion.API.HumanResources.Controllers
{
    [Route("api/demoCalendars")]
    public class DemoCalendarsController(
        IEmployeeService employeeService,
        IMapper mapper) : ControllerBase
    {
        private readonly IMapper _mapper = mapper;

        [HttpPost]
        public async Task<ActionResult<CalendarDto>> CreateCalendar(
            CalendarForCreationDto calendarForCreation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // create an internal employee entity with default values filled out
            // and the values inputted via the POST request
            var Calendar =
                    await employeeService.CreateCalendarAsync(
                        calendarForCreation.FirstName, calendarForCreation.LastName);

            // persist it
            await employeeService.AddCalendarAsync(Calendar);

            // return created employee after mapping to a DTO
            return CreatedAtAction("GetCalendar",
                _mapper.Map<CalendarDto>(Calendar),
                new { employeeId = Calendar.Id });
        }


        [HttpGet]
        [Authorize]
        public IActionResult GetProtectedCalendars()
        {
            // depending on the role, redirect to another action
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction(
                    "GetCalendars", "ProtectedCalendars");
            }

            return RedirectToAction("GetCalendars", "Calendars");
        }

    }
}
